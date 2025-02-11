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
    public partial class EditEmployeeInfoUC : UserControl
    {
        public EditEmployeeInfoUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.dgvEmployee.ClearSelection();
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

        private string ID { get; set; }
        private DataAccess Da { get; set; }
        private void PopulateGridView(string sql = "select * from UserInfo where Role = 'Employee';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (this.txtSearch.Text == "Search By ID")
            {

                this.txtSearch.Text = "";
                this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (this.txtSearch.Text == "")
            {

                this.txtSearch.Text = "Search By ID";
                this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
                this.PopulateGridView();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search By ID" || string.IsNullOrEmpty(txtSearch.Text) == false || string.IsNullOrWhiteSpace(txtSearch.Text) == false)
            {
                var sql = "select * from UserInfo where U_ID like '%" + this.txtSearch.Text + "%' and Role = 'Employee';";
                this.PopulateGridView(sql);
            }
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            TurnOffReadOnly();
            if (this.dgvEmployee.SelectedRows.Count == 0) { return; }
            this.txtFullName.Text = this.dgvEmployee.CurrentRow.Cells["FullName"].Value.ToString();
            this.txtPhone.Text = this.dgvEmployee.CurrentRow.Cells["Phone"].Value.ToString();
            this.txtSalary.Text = this.dgvEmployee.CurrentRow.Cells["Salary"].Value.ToString();
            this.cmbGender.Text = this.dgvEmployee.CurrentRow.Cells["Gender"].Value.ToString();
            this.txtPassword.Text = this.dgvEmployee.CurrentRow.Cells["Password"].Value.ToString();
            this.ID = this.dgvEmployee.CurrentRow.Cells["U_ID"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
            TurnOnReadOnly();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) == true)
            {

                lblFullnameError.Visible = true;

            }
            else
            {

                lblFullnameError.Visible = false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text) == true)
            {
                lblPhoneError.Visible = true;
            }
            else
            {
                lblPhoneError.Visible = false;
            }
            if (string.IsNullOrEmpty(txtSalary.Text) == true)
            {

                lblSalaryError.Visible = true;

            }
            else
            {
                lblSalaryError.Visible = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {

                lblPasswordError.Visible = true;
            }
            else
            {

                lblPasswordError.Visible = false;
            }
            if (string.IsNullOrEmpty(cmbGender.Text))
            {
                lblGenderError.Visible = true;
            }
            else
            {
                lblGenderError.Visible = false;


            }

            if (lblFullnameError.Visible == true || lblPhoneError.Visible == true || lblSalaryError.Visible == true || lblPasswordError.Visible == true || lblGenderError.Visible == true)
            {
                return;
            }


            if (txtPhone.Text.Length != 11)
            {
                lblPhoneError.Visible = true;
                MessageBox.Show("Phone number has to be 11 digit");
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
            if (lblFullnameError.Visible == true || lblPhoneError.Visible == true || lblSalaryError.Visible == true || lblPasswordError.Visible == true || lblGenderError.Visible == true)
            {
                return;
            }

            

                DialogResult result = MessageBox.Show("Save Changes?", "Confirmation!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {

                var query = "select * from UserInfo where U_ID = '" + this.ID + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"update UserInfo
                                set FullName = '" + this.txtFullName.Text + @"',
                                Password = '" + this.txtPassword.Text + @"',
                                Phone = '" + this.txtPhone.Text + @"',
                                Gender = '" + this.cmbGender.Text + @"',
                                Salary = " + this.txtSalary.Text + @"
                                where U_ID = '" + this.ID + "';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");

                }
                else {
                    return;
                }

                
            }

            this.ClearInfo();
            this.PopulateGridView();
            TurnOnReadOnly();
        }

        private void TurnOffReadOnly()
        {

            txtFullName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtSalary.ReadOnly = false;
            cmbGender.Enabled = true;
        }
        private void TurnOnReadOnly()
        {

            txtFullName.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtSalary.ReadOnly = true;
            cmbGender.Enabled = false;
        }

        private void TurnOffVisibility()
        {
            lblFullnameError.Visible = false;
            lblPasswordError.Visible = false;
            lblPhoneError.Visible = false;
            lblSalaryError.Visible = false;
            lblGenderError.Visible = false;
        }
        private void ClearInfo()
        {
            this.txtFullName.Clear();
            this.txtPhone.Clear();
            this.txtSalary.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.txtPassword.Clear();

            TurnOffVisibility();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
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

        private void lblInvalidLogin_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
