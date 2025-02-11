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
    public partial class CartUC : UserControl
    {
        public CartUC(string u, string p)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.dgvProduct.ClearSelection();
            this.dgvCart.ClearSelection();
            Username = u;
            Password = p;
        }
        private string Username { get; set; }
        private string Password { get; set; }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
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
            if (this.dgvProduct.SelectedRows.Count <= 0) return;
            var pID = dgvProduct.CurrentRow.Cells["P_ID"].Value.ToString();
            this.AddToCart(pID);
        }

        private void AddToCart(string pID)
        {
            try
            {
                int i = 0;
                while (i < dgvCart.Rows.Count)
                {
                    string val = dgvCart.Rows[i].Cells["P_IDcart"].Value.ToString();
                    if (val.Equals(pID))
                    {
                        MessageBox.Show("Product exists in the cart");
                        return;
                    }
                    i++;
                }


                string sql = "select P_ID, ProductName, Price, Quantity from ProductInfo where P_ID = '" + pID + "';";
                var dt = Da.ExecuteQueryTable(sql);
                this.dgvCart.AutoGenerateColumns = false;
                string[] row = new string[] { dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), "1", dt.Rows[0][3].ToString() };
                this.dgvCart.Rows.Add(row);
                this.CalculateCost();

            }

            catch (Exception e)
            {
                return;
            }
        }


        private double CalculateCost(int q = 1)
        {

            int index = 0;
            double total = 0.0;


            while (index < this.dgvCart.RowCount)
            {
                var price = Double.Parse(this.dgvCart.Rows[index].Cells["PriceCart"].Value.ToString());
                var quantity = Double.Parse(this.dgvCart.Rows[index].Cells["QuantityCart"].Value.ToString());
                total += price * quantity;
                index++;
            }

            this.lblTotalPrice.Text = total.ToString() + "$";
            return total;
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            this.dgvCart.DataSource = null;
            this.dgvCart.Rows.Clear();
            this.CalculateCost();
        }
        

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int currentQuantity = 0;
                if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("Increment"))
                {
                    currentQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["QuantityCart"].Value.ToString());
                    var totalQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["TotalQuantityCart"].Value.ToString());
                    if (totalQuantity == currentQuantity) {
                        MessageBox.Show("Out of stock");
                        return;
                    }
                    this.dgvCart.CurrentRow.Cells["QuantityCart"].Value = (++currentQuantity).ToString();
                    this.CalculateCost(currentQuantity);
                }
                else if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("Decrement"))
                {
                    currentQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["QuantityCart"].Value.ToString());
                    if (currentQuantity == 1)
                    {
                        return;
                    }
                    this.dgvCart.CurrentRow.Cells["QuantityCart"].Value = (--currentQuantity).ToString();
                    this.CalculateCost(currentQuantity);
                }
                else if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("DeleteButton"))
                {
                    if (this.dgvCart.SelectedRows.Count <= 0) return;
                    this.dgvCart.Rows.RemoveAt(e.RowIndex);
                    this.CalculateCost();
                }
          
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (CalculateCost() == 0) return;

            string[] a = lblTotalPrice.Text.Split('$');
            double amountPaid = Convert.ToDouble(a[0]);
            


            CustomerInfo customerInfo = new CustomerInfo(Username, Password, amountPaid);
            customerInfo.Show();
            int index = 0;
            while (index < this.dgvCart.Rows.Count)
            {
                var sql = $@"update ProductInfo set Quantity = Quantity - {this.dgvCart.Rows[index].Cells["QuantityCart"].Value.ToString()} where P_ID = '{this.dgvCart.Rows[index].Cells["P_IDcart"].Value.ToString()}';";
                Da.ExecuteDMLQuery(sql);
                index++;
            }
            

            this.dgvCart.DataSource = null;
            this.dgvCart.Rows.Clear();
            this.CalculateCost();
            this.PopulateGridView();
        }
    }
}
