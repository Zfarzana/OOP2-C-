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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo(string u, string p, double amountPaid)
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToString("D");
            this.lblTotalPrice.Text = amountPaid.ToString() + "$";
            Username = u;
            Password = p;
            AmountPaid = amountPaid;
            this.Da = new DataAccess();
        }
        private DataAccess Da { get; set; }

        public string CustomerName { get; set; }
        private string Username { get; set; }
        private double AmountPaid { get; set; }
        private string Password { get; set; }
        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            if (this.txtCustomerName.Text == "Customer Name")
            {

                this.txtCustomerName.Text = "";
                this.txtCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (this.txtCustomerName.Text == "")
            {

                this.txtCustomerName.Text = "Customer Name";
                this.txtCustomerName.ForeColor = System.Drawing.SystemColors.GrayText;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Customer Name" || string.IsNullOrEmpty(txtCustomerName.Text) == true)
            {
                lblCustomerNameError.Visible = true;
                return;
            }
            CustomerName = this.txtCustomerName.Text;
            lblCustomerNameError.Visible = false;

            string transactionID = "T-" + AutoId();
            var sql = @"select U_ID from UserInfo where Username = '" + Username + "' and Password = '" + Password + "';";
            var ds = Da.ExecuteQuery(sql);
            string uID = ds.Tables[0].Rows[0][0].ToString();
            string purchaseDate = DateTime.Now.ToString("d");
            var query = @"insert into SalesHistory values('" + transactionID + "', '" + uID + "', '" + Username + "', '" + CustomerName + "', " + AmountPaid + ", '" + purchaseDate + "');";
            
            ds = Da.ExecuteQuery(query);

            MessageBox.Show("Thank You For Shopping With Us");
            this.Close();
        }
        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from SalesHistory order by T_ID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");

        }
    }
}
