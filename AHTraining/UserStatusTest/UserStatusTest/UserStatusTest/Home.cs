using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace UserStatusTest
{
    public partial class Home : Form
    {
        private HttpClient _Client = null;
        private List<User> _Users = new List<User>();
        private string _SelectedStatus = "";

        public Home()
        {
            _Client = new HttpClient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 20941; i < 50000; i++)
            //{
            //    var res = _Client.PostAsync(@"http://localhost:63015/api/UserStat",
            //                    new StringContent(JsonConvert.SerializeObject(new User { Username = "User"+ i, Stat = null}), Encoding.UTF8, "application/json"));
            //    var tmp = res.Result;
            //}

            GetData();
        }

        private void GetData()
        {
            var data = _Client.GetStringAsync(@"http://localhost:63015/api/UserStat");
            _Users = JsonConvert.DeserializeObject<List<User>>(data.Result);
            var usernames = new List<string>();
            foreach (var item in _Users)
            {
                usernames.Add(item.Username);
            }
            cmbUserName.DataSource = usernames;
        }

        private void checkChanged(object sender, EventArgs e)
        {
            var idx = cmbUserName.SelectedIndex;
            if (radU.Checked)
            {
                _Users[idx].Stat = "U";
                _SelectedStatus = "U";
                return;
            }
            if (radI.Checked)
            {
                _Users[idx].Stat = "I";
                _SelectedStatus = "I";
                return;
            }
            if (radN.Checked)
            {
                _Users[idx].Stat = "N";
                _SelectedStatus = "N";
                return;
            }
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = cmbUserName.SelectedIndex;
            var status = _Users[idx].Stat;

            radU.Checked = false;
            radI.Checked = false;
            radN.Checked = false;

            if (status == "U")
            {
                radU.Checked = true;
                return;
            }
            if (status == "I")
            {
                radI.Checked = true;
                return;
            }
            if (status == "N")
            {
                radN.Checked = true;
                return;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var user = _Users[cmbUserName.SelectedIndex];
            var res = _Client.PutAsync(@"http://localhost:63015/api/UserStat", 
                new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            var tmp = res.Result;
            GetData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBulkSend_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (Int32.TryParse(txtBulkCount.Text, out count))
            {
                lblStatus.Text = "Starting Upload..";
                Stopwatch sw = new Stopwatch();
                sw.Start();

                //for(int i = 0; i < count; i++)
                var parRes = Parallel.For(0, count, i =>
                {
                    var res = _Client.PutAsync(@"http://localhost:63015/api/UserStat",
                        new StringContent(
                            JsonConvert.SerializeObject(
                                new User { Username = "User" + i, Stat = _SelectedStatus }),
                            Encoding.UTF8, "application/json"));
                    var tmp = res.Result;
                });

                sw.Stop();
                lblStatus.Text = string.Format("Elapsed: {0}, Time: {1}", sw.Elapsed, DateTime.Now.ToLongTimeString());
            }
        }
    }
}
