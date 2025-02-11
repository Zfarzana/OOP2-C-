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
    public partial class EditProductInfoUC : UserControl
    {
        public EditProductInfoUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.dgvProduct.ClearSelection();
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
        private void PopulateGridView(string sql = "select * from ProductInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
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
                var sql = "select * from ProductInfo where P_ID like '%" + this.txtSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            TurnOffReadOnly();
            if (this.dgvProduct.SelectedRows.Count == 0) { return; }
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            this.txtBrand.Text = this.dgvProduct.CurrentRow.Cells["Brand"].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells["Quantity"].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells["Price"].Value.ToString();
            this.ID = this.dgvProduct.CurrentRow.Cells["P_ID"].Value.ToString();
        }

        private void TurnOffReadOnly()
        {

            txtProductName.ReadOnly = false;
            txtBrand.ReadOnly = false;
            txtQuantity.ReadOnly = false;
            txtPrice.ReadOnly = false;

        }
        private void TurnOnReadOnly()
        {

            txtProductName.ReadOnly = true;
            txtBrand.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtPrice.ReadOnly = true;
        }
        private void ClearInfo()
        {
            txtProductName.Clear();
            txtBrand.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();

            TurnOffVisibility();
        }

        private void TurnOffVisibility()
        {
            lblProductNameError.Visible = false;
            lblBrandError.Visible = false;
            lblQuantityError.Visible = false;
            lblPriceError.Visible = false;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
            TurnOnReadOnly();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            //Exceptions


            if (string.IsNullOrEmpty(txtProductName.Text) == true)
            {

                lblProductNameError.Visible = true;

            }
            else
            {

                lblProductNameError.Visible = false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text) == true)
            {

                lblPriceError.Visible = true;
            }
            else
            {

                lblPriceError.Visible = false;
            }
            if ( string.IsNullOrEmpty(txtBrand.Text) == true)
            {
                lblBrandError.Visible = true;


            }
            else
            {

                lblBrandError.Visible = false;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text) == true)
            {

                lblQuantityError.Visible = true;

            }
            else
            {

                lblQuantityError.Visible = false;
            }

            if (lblQuantityError.Visible == true || lblProductNameError.Visible == true || lblPriceError.Visible == true || lblQuantityError.Visible == true)
            {
                return;
            }

            double pricee = Convert.ToDouble(this.txtPrice.Text);
            int quantityy = Convert.ToInt32(this.txtQuantity.Text);


            if (pricee == 0)
            {
                lblPriceError.Visible = true;
                MessageBox.Show("Price can not be 0");
                return;
            }
            else
            {
                lblPriceError.Visible = false;

            }
            if (quantityy == 0)
            {
                lblQuantityError.Visible = true;
                MessageBox.Show("Quantity can not be 0");
                return;
            }
            else
            {
                lblQuantityError.Visible = false;

            }

            DialogResult result = MessageBox.Show("Save Changes?", "Confirmation!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                string query = "select * from ProductInfo where P_ID = '" + this.ID + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"update ProductInfo
                                set ProductName = '" + this.txtProductName.Text + @"',
                                Brand = '" + this.txtBrand.Text + @"',
                                Quantity = " + this.txtQuantity.Text + @",
                                Price = " + this.txtPrice.Text + @"
                                where P_ID = '" + this.ID + "';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }

            }
                else
                {
                    return;
                }

                

            this.ClearInfo();
            this.PopulateGridView();
            TurnOnReadOnly();
        }
    }
}
