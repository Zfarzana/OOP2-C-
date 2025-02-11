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
    public partial class Settings : Form
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
        public Settings(string username)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.txtUsername.Text = username;
            this.UID(username);
        }

        private string ID { get; set; }
        private DataAccess Da { get; set; }

        private void lblPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Enter new password")
            {

                this.txtPassword.Text = "";
                this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void lblPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {

                this.txtPassword.Text = "Enter new password";
                this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        public void UID(string u)
        {

            var query = @"select U_ID from UserInfo where Username = '" + u + "';";
            var ds = Da.ExecuteQuery(query);
            this.ID = ds.Tables[0].Rows[0][0].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter new password" || string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                lblPasswordError.Visible = true;
                return;
            }
            else
            {
                lblPasswordError.Visible = false;
            }

            DialogResult result = MessageBox.Show("Change Password?", "Confirmation!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                var sql = "update UserInfo set Password = '" + this.txtPassword.Text + @"' where U_ID = '" + this.ID + "';";
                this.Da.ExecuteDMLQuery(sql);
                MessageBox.Show("Password changed");

                this.txtPassword.Text = "Enter new password";
                this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;

            }
                else return;

            }
       
    }
}
