using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WinEntityFramework
{
    public partial class EmpData : Form
    {
        private EmployeeBLL _employeeBLL;

        public EmpData()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void EmpData_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _employeeBLL.SelectEmployee();
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            MaximumSize = Size;
            MinimumSize = Size;
            MaximizeBox = false;
        }
    }
}
