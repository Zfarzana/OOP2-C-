namespace ArtShopManagementSystem
{
    partial class CustomerInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI.WinForms.GunaButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCustomerNameError = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblCustomerNameError);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 306);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer Information :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AnimationHoverSpeed = 0.07F;
            this.btnConfirm.AnimationSpeed = 0.03F;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BaseColor = System.Drawing.Color.White;
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirm.Location = new System.Drawing.Point(352, 261);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverImage = null;
            this.btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirm.Radius = 8;
            this.btnConfirm.Size = new System.Drawing.Size(83, 25);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(107, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(125, 17);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date - Month - Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date Today :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(170, 165);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(40, 21);
            this.lblTotalPrice.TabIndex = 21;
            this.lblTotalPrice.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 21);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Amount to be paid : ";
            // 
            // lblCustomerNameError
            // 
            this.lblCustomerNameError.AutoSize = true;
            this.lblCustomerNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNameError.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerNameError.Location = new System.Drawing.Point(205, 111);
            this.lblCustomerNameError.Name = "lblCustomerNameError";
            this.lblCustomerNameError.Size = new System.Drawing.Size(21, 25);
            this.lblCustomerNameError.TabIndex = 19;
            this.lblCustomerNameError.Text = "*";
            this.lblCustomerNameError.Visible = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.BaseColor = System.Drawing.Color.White;
            this.txtCustomerName.BorderColor = System.Drawing.Color.Black;
            this.txtCustomerName.BorderSize = 1;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCustomerName.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtCustomerName.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCustomerName.Location = new System.Drawing.Point(28, 105);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.Radius = 8;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(160, 30);
            this.txtCustomerName.TabIndex = 55;
            this.txtCustomerName.Text = "Customer Name";
            this.txtCustomerName.TextOffsetX = 5;
            this.txtCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtCustomerName.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomerNameError;
        private Guna.UI.WinForms.GunaTextBox txtCustomerName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnConfirm;
    }
}