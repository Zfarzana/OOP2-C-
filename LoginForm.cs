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
    public partial class LoginForm : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        private DataAccess Da { get; set; }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "Username") {

                this.txtUsername.Text = "";
                this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
            {

                this.txtUsername.Text = "Username";
                this.txtUsername.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Password")
            {

                this.txtPassword.Text = "";
                this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {

                this.txtPassword.Text = "Password";
                this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;

            }
        }
        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnInvisible.BringToFront();
            }
        }

        private void btnInvisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnVisible.BringToFront();
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnInvisible.Visible = true;
            btnVisible.Visible = true;
            btnInvisible.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Username = '"+txtUsername.Text+"' and Password = '"+txtPassword.Text+"';";
            var ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {

                if (ds.Tables[0].Rows[0][6].ToString() == "Owner") {

                    new OwnerHome(this.txtUsername.Text, this).Show();
                    this.Hide();

                }
                else if (ds.Tables[0].Rows[0][6].ToString() == "Employee") {

                    new EmployeeHome(this.txtUsername.Text, this.txtPassword.Text, this).Show();
                    this.Hide();

                }

            }
            else if (ds.Tables[0].Rows.Count == 0) {

                this.lblInvalidLogin.Visible = true;
            
            }
        }
    }
}
