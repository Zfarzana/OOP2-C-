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
    public partial class EmployeeSalesHistoryUC : UserControl
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
        public EmployeeSalesHistoryUC(string username, string password)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.dgvTransaction.ClearSelection();
            UID(username, password);
            this.PopulateGridView();
        }

        private DataAccess Da { get; set; }
        private string ID { get; set; }

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
                string sql = "select * from SalesHistory where T_ID like '%" + this.txtSearch.Text + "%' and U_ID = '"+ID+"';";
                this.PopulateGridView(sql);
            }
        }
        public void UID(string u, string p)
        {

            string query = @"select U_ID from UserInfo where Username = '" + u + "' and Password = '" + p + "';";
            var ds = Da.ExecuteQuery(query);
            this.ID = ds.Tables[0].Rows[0][0].ToString();

        }
        private void PopulateGridView(string sql = null)
        {
            if (sql == null) {

                sql = "select * from SalesHistory where U_ID = '" + this.ID + "';";

            }

            var ds = this.Da.ExecuteQuery(sql);

            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.DataSource = ds.Tables[0];
        }
    }
}
