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

namespace UserStatusTest
{
    public partial class Home : Form
    {
        private HttpClient _Client = null;
        private List<User> _Users = new List<User>();

        public Home()
        {
            _Client = new HttpClient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                return;
            }
            if (radI.Checked)
            {
                _Users[idx].Stat = "I";
                return;
            }
            if (radN.Checked)
            {
                _Users[idx].Stat = "N";
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
    }
}
