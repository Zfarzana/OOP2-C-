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
    public partial class AddProductUC : UserControl
    {
        public AddProductUC()
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

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            if (this.txtProductName.Text == "Product Name")
            {

                this.txtProductName.Text = "";
                this.txtProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (this.txtProductName.Text == "")
            {

                this.txtProductName.Text = "Product Name";
                this.txtProductName.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtBrand_Enter(object sender, EventArgs e)
        {
            if (this.txtBrand.Text == "Brand")
            {

                this.txtBrand.Text = "";
                this.txtBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtBrand_Leave(object sender, EventArgs e)
        {
            if (this.txtBrand.Text == "")
            {

                this.txtBrand.Text = "Brand";
                this.txtBrand.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (this.txtQuantity.Text == "Quantity")
            {

                this.txtQuantity.Text = "";
                this.txtQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (this.txtQuantity.Text == "")
            {

                this.txtQuantity.Text = "Quantity";
                this.txtQuantity.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (this.txtPrice.Text == "Price")
            {

                this.txtPrice.Text = "";
                this.txtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (this.txtPrice.Text == "")
            {

                this.txtPrice.Text = "Price";
                this.txtPrice.ForeColor = System.Drawing.SystemColors.GrayText;


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            this.txtProductName.Text = "Product Name";
            this.txtProductName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBrand.Text = "Brand";
            this.txtBrand.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrice.Text = "Price";
            this.txtPrice.ForeColor = System.Drawing.SystemColors.GrayText;

            TurnOffVisibility();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            //Exceptions


            if (txtProductName.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtProductName.Text) == true)
            {

                lblProductNameError.Visible = true;

            }
            else
            {

                lblProductNameError.Visible = false;
            }
            if (txtPrice.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtPrice.Text) == true)
            {

                lblPriceError.Visible = true;
            }
            else
            {

                lblPriceError.Visible = false;
            }
            if (txtBrand.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtBrand.Text) == true)
            {
                lblBrandError.Visible = true;


            }
            else
            {

                lblBrandError.Visible = false;
            }
            if (txtQuantity.ForeColor == System.Drawing.SystemColors.GrayText || string.IsNullOrEmpty(txtQuantity.Text) == true)
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



            string PID = "P-" + this.AutoId();
            string productName = txtProductName.Text;
            string brand = txtBrand.Text;
            string quantity = txtQuantity.Text;
            string price = txtPrice.Text;


            string sql = "insert into ProductInfo values ('" + PID + "', '" + productName + "', '" + brand + "', " + quantity + ", " + price + ")  ;";
            var ds = this.Da.ExecuteQuery(sql);
            MessageBox.Show("New Product Added");

            ClearAll();
        }
        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from ProductInfo order by P_ID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TurnOffVisibility()
        {
            lblProductNameError.Visible = false;
            lblBrandError.Visible = false; 
            lblQuantityError.Visible = false;
            lblPriceError.Visible = false;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
