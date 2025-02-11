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
    public partial class DeleteProductUC : UserControl
    {
        public DeleteProductUC()
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.Columns[e.ColumnIndex].Name.Equals("DeleteButton"))
            {
                DialogResult result = MessageBox.Show("Delete Product?", "Confirmation!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    var sql = "DELETE FROM ProductInfo WHERE P_ID = '" + this.dgvProduct.CurrentRow.Cells["P_ID"].Value.ToString() + "';";
                    this.Da.ExecuteDMLQuery(sql);
                    MessageBox.Show("Product Deleted");
                    this.PopulateGridView();

                }
                else return;
            }
        }
    }
}
