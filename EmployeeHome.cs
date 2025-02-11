using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtShopManagementSystem
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome(string username, string password, LoginForm lf)
        {
            InitializeComponent();
            this.lblUsername.Text = "Hello, " + username;
            this.Username = username;
            this.Password = password;
            this.Lf = lf;
            this.AddUserControl(new CartUC(username, password));
        }
        private LoginForm Lf { get; set; }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private string Username { get; set; }
        private string Password { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings(Username).ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Lf.Show();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new EmployeeSalesHistoryUC(Username, Password));
            btnHome.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new CartUC(Username, Password));
            btnHome.Visible = false;
        }
    }
}
