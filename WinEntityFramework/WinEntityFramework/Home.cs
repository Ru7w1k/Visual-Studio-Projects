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
    public partial class Home : Form
    {
        private EmployeeBLL _employeeBLL;
        private int _height, _width;

        public Home()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            _height = Screen.PrimaryScreen.Bounds.Height;
            _width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = txtName.Text;
            emp.Salary = Convert.ToDouble(txtSalary.Text);
            emp.DeptNo = Convert.ToInt32(txtDeptNo.Text);

            _employeeBLL.InsertEmployee(emp);
            MessageBox.Show(string.Format("Employee {0} Added!", emp.EmpId));
            txtEmpId.Text = emp.EmpId.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpId = Convert.ToInt32(txtEmpId.Text);
            emp.Name = txtName.Text;
            emp.Salary = Convert.ToDouble(txtSalary.Text);
            emp.DeptNo = Convert.ToInt32(txtDeptNo.Text);

            _employeeBLL.UpdateEmployee(emp);
            MessageBox.Show("Updated Employee " + emp.EmpId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpId = Convert.ToInt32(txtEmpId.Text);

            _employeeBLL.DeleteEmployee(emp);
            MessageBox.Show("Deleted Employee " + emp.EmpId);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            EmpData empData = new EmpData();
            empData.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            pnlMain.Location = new Point(Convert.ToInt32(_width * 0.55f), Convert.ToInt32(_height * 0.05f));
            pnlMain.Size = new Size(Convert.ToInt32(_width * 0.30), Convert.ToInt32(_height * 0.85));

            //pnlFields.Controls.Add(lblEmpId);
            //pnlFields.Controls.Add(txtEmpId);
            //pnlFields.Controls.Add(lblName);
            //pnlFields.Controls.Add(txtName);
            //pnlFields.Controls.Add(lblSalary);
            //pnlFields.Controls.Add(txtSalary);
            //pnlFields.Controls.Add(lblDeptNo);
            //pnlFields.Controls.Add(txtDeptNo);

            //pnlButtons.Controls.Add(btnView);
            //pnlButtons.Controls.Add(btnInsert);
            //pnlButtons.Controls.Add(btnUpdate);
            //pnlButtons.Controls.Add(btnDelete);

            ////pnlFields.Location = new Point(pnlFields.Parent.Location.X 

            //pnlMain.Controls.Add(pnlFields);
            //pnlMain.Controls.Add(pnlButtons);

        }
        
    }
}
