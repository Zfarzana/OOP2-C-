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
    public partial class OwnerHome : Form
    {
        public OwnerHome(string username, LoginForm lf)
        {
            InitializeComponent();
            this.lblUsername.Text = "Hello, " + username;
            this.Lf = lf;
        }
        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbManageEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblManageEmployee.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblManageProduct.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Lf.Show();
        }

        private void cmbManageEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbManageEmployee.GetItemText(cmbManageEmployee.SelectedItem) == "Add Employee") {
                this.AddUserControl(new AddEmployeeUC());
            }
            else if (cmbManageEmployee.GetItemText(cmbManageEmployee.SelectedItem) == "Edit Employee Info")
            {
                this.AddUserControl(new EditEmployeeInfoUC());
            }
            else if (cmbManageEmployee.GetItemText(cmbManageEmployee.SelectedItem) == "Delete Employee")
            {
                this.AddUserControl(new DeleteEmployeeUC());
            }
        }

        private void cmbManageProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbManageProduct.GetItemText(cmbManageProduct.SelectedItem) == "Add Product")
            {
                this.AddUserControl(new AddProductUC());
            }
            else if (cmbManageProduct.GetItemText(cmbManageProduct.SelectedItem) == "Edit Product Info")
            {
                this.AddUserControl(new EditProductInfoUC());
            }
            else if (cmbManageProduct.GetItemText(cmbManageProduct.SelectedItem) == "Delete Product")
            {
                this.AddUserControl(new DeleteProductUC());
            }
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            this.AddUserControl(new OwnerSalesHistoryUC());
        }

        private void txtMemo1_Enter(object sender, EventArgs e)
        {
            if (this.txtMemo1.Text == "Type your note")
            {

                this.txtMemo1.Text = "";
                this.txtMemo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtMemo1_Leave(object sender, EventArgs e)
        {
            if (this.txtMemo1.Text == "")
            {

                this.txtMemo1.Text = "Type your note";
                this.txtMemo1.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtMemo2_Enter(object sender, EventArgs e)
        {
            if (this.txtMemo2.Text == "Type your note")
            {

                this.txtMemo2.Text = "";
                this.txtMemo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtMemo2_Leave(object sender, EventArgs e)
        {
            if (this.txtMemo2.Text == "")
            {

                this.txtMemo2.Text = "Type your note";
                this.txtMemo2.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtMemo3_Enter(object sender, EventArgs e)
        {
            if (this.txtMemo3.Text == "Type your note")
            {

                this.txtMemo3.Text = "";
                this.txtMemo3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtMemo3_Leave(object sender, EventArgs e)
        {
            if (this.txtMemo3.Text == "")
            {

                this.txtMemo3.Text = "Type your note";
                this.txtMemo3.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.lblMemo1.Text = "Note Goes Here";
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            this.lblMemo2.Text = "Note Goes Here";
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            this.lblMemo3.Text = "Note Goes Here";
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            if (this.txtMemo1.Text == "Type your note") return;
            else if (this.txtMemo1.Text.Length <= 15) 
            { 
                this.lblMemo1.Text = txtMemo1.Text;
                txtMemo1.Clear();
            }
            else { MessageBox.Show("15 characters maximum");
                return; 
            }
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            if (this.txtMemo2.Text == "Type your note") return;
            else if (this.txtMemo2.Text.Length <= 15)
            { 
                this.lblMemo2.Text = txtMemo2.Text;
                txtMemo2.Clear();

            }
            else
            {
                MessageBox.Show("15 characters maximum");
                return;
            }
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            if (this.txtMemo3.Text == "Type your note") return;
            else if (this.txtMemo3.Text.Length <= 15)
            {
                this.lblMemo3.Text = txtMemo3.Text;
                return;
            }
            else
            {
                MessageBox.Show("15 characters maximum");
                return;
            }
        }
    }
}
