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
    public partial class AddEmployeeUC : UserControl
    {
        public AddEmployeeUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        DataAccess Da { get; set; }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (this.txtFullName.Text == "Full Name")
            {

                this.txtFullName.Text = "";
                this.txtFullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (this.txtFullName.Text == "")
            {

                this.txtFullName.Text = "Full Name";
                this.txtFullName.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "Username")
            {

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

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (this.txtPhone.Text == "Phone Number")
            {

                this.txtPhone.Text = "";
                this.txtPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (this.txtPhone.Text == "")
            {

                this.txtPhone.Text = "Phone Number";
                this.txtPhone.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (this.txtSalary.Text == "Salary")
            {

                this.txtSalary.Text = "";
                this.txtSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (this.txtSalary.Text == "")
            {

                this.txtSalary.Text = "Salary";
                this.txtSalary.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {

            string UID = "U-" + this.AutoId();
            string fullName = txtFullName.Text;
            string userName = txtUsername.Text;
            string phoneNumber = txtPhone.Text;
            string password = txtPassword.Text;
            string gender = "null";
            string role = "Employee";
            string salary = txtSalary.Text;

            if (rbtnFemale.Checked == true)
            {
                gender = "Female";
            }
            else if (rbtnMale.Checked == true)
            {
                gender = "Male";
            }

            //Exceptions
            if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
            {
                lblMaleError.Visible = true;
                lblFemaleError.Visible = true;
            }
            else{

                lblMaleError.Visible = false;
                lblFemaleError.Visible = false;

            }
            if (txtFullName.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtFullName.Text) == true)
            {

                lblFullnameError.Visible = true;

            }
            else
            {

                lblFullnameError.Visible = false;
            }
            if (txtUsername.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtUsername.Text) == true)
            {

                lblUsernameError.Visible = true;
            }
            else
            {

                lblUsernameError.Visible = false;
            }
            if (txtPhone.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtPhone.Text) == true)
            {
                lblPhoneError.Visible = true;


            }
            else
            {

                lblPhoneError.Visible = false;
            }
            if (txtSalary.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtSalary.Text) == true)
            {

                lblSalaryError.Visible = true;

            }
            else
            {

                lblSalaryError.Visible = false;
            }

            if (txtPassword.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtPassword.Text) == true)
            {

                lblPasswordError.Visible = true;

            }
            else
            {
                lblPasswordError.Visible = false;
            }
            if (txtPhone.Text.Length != 11)
            {
                lblPhoneError.Visible = true;
                MessageBox.Show("Number has to be 11 digits");
                return;
            }
            else
            {
                lblPhoneError.Visible = false;

            }
            if (txtPhone.Text.Substring(0, 2) != "01")
            {
                lblPhoneError.Visible = true;
                MessageBox.Show("Invalid Phone Number");
                return;
            }
            else
            {
                lblPhoneError.Visible = false;
            }

            //Username Existance Check

            string sql = "select * from UserInfo where Username = '" + userName + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                lblUsernameError.Visible = true;
                MessageBox.Show("Username already exists");

            }

            if (lblFullnameError.Visible == true || lblUsernameError.Visible == true || lblPhoneError.Visible == true || lblSalaryError.Visible == true || lblPasswordError.Visible == true || lblMaleError.Visible == true || lblFemaleError.Visible == true)
            {id('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }
        private void ClearAll()
        {
            this.txtFullName.Text = "Full Name";
            this.txtFullName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsername.Text = "Username";
            this.txtUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPassword.Text = "Password";
            this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPhone.Text = "Phone Number";
            this.txtPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSalary.Text = "Salary";
            this.txtSalary.ForeColor = System.Drawing.SystemColors.GrayText;

            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;

            TurnOffVisibility();
        }
        private void TurnOffVisibility()
        {
            lblFullnameError.Visible = false;
            lblPasswordError.Visible = false;
            lblPhoneError.Visible = false;
            lblSalaryError.Visible = false;
            lblUsernameError.Visible = false;
            lblMaleError.Visible = false;
            lblFemaleError.Visible = false;
        }
        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

    }
}
