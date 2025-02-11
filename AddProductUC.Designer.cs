namespace ArtShopManagementSystem
{
    partial class AddProductUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPriceError = new System.Windows.Forms.Label();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.lblBrandError = new System.Windows.Forms.Label();
            this.lblProductNameError = new System.Windows.Forms.Label();
            this.btnAddProduct = new Guna.UI.WinForms.GunaButton();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.txtBrand = new Guna.UI.WinForms.GunaTextBox();
            this.txtProductName = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceError.ForeColor = System.Drawing.Color.Red;
            this.lblPriceError.Location = new System.Drawing.Point(506, 236);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(21, 25);
            this.lblPriceError.TabIndex = 38;
            this.lblPriceError.Text = "*";
            this.lblPriceError.Visible = false;
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(506, 190);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(21, 25);
            this.lblQuantityError.TabIndex = 37;
            this.lblQuantityError.Text = "*";
            this.lblQuantityError.Visible = false;
            // 
            // lblBrandError
            // 
            this.lblBrandError.AutoSize = true;
            this.lblBrandError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandError.ForeColor = System.Drawing.Color.Red;
            this.lblBrandError.Location = new System.Drawing.Point(506, 143);
            this.lblBrandError.Name = "lblBrandError";
            this.lblBrandError.Size = new System.Drawing.Size(21, 25);
            this.lblBrandError.TabIndex = 36;
            this.lblBrandError.Text = "*";
            this.lblBrandError.Visible = false;
            // 
            // lblProductNameError
            // 
            this.lblProductNameError.AutoSize = true;
            this.lblProductNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameError.ForeColor = System.Drawing.Color.Red;
            this.lblProductNameError.Location = new System.Drawing.Point(506, 95);
            this.lblProductNameError.Name = "lblProductNameError";
            this.lblProductNameError.Size = new System.Drawing.Size(21, 25);
            this.lblProductNameError.TabIndex = 35;
            this.lblProductNameError.Text = "*";
            this.lblProductNameError.Visible = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AnimationHoverSpeed = 0.07F;
            this.btnAddProduct.AnimationSpeed = 0.03F;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BaseColor = System.Drawing.Color.White;
            this.btnAddProduct.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.BorderSize = 1;
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Image = null;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddProduct.Location = new System.Drawing.Point(419, 288);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverImage = null;
            this.btnAddProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProduct.Radius = 8;
            this.btnAddProduct.Size = new System.Drawing.Size(119, 42);
            this.btnAddProduct.TabIndex = 32;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.White;
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.BorderSize = 1;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = null;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(277, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 8;
            this.btnClear.Size = new System.Drawing.Size(119, 42);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrice.Location = new System.Drawing.Point(327, 231);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Radius = 8;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(160, 30);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.Text = "Price";
            this.txtPrice.TextOffsetX = 5;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.Black;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQuantity.Location = new System.Drawing.Point(327, 185);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.Radius = 8;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(160, 30);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.TextOffsetX = 5;
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.Transparent;
            this.txtBrand.BaseColor = System.Drawing.Color.White;
            this.txtBrand.BorderColor = System.Drawing.Color.Black;
            this.txtBrand.BorderSize = 1;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBrand.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtBrand.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBrand.Location = new System.Drawing.Point(327, 138);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.Radius = 8;
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(160, 30);
            this.txtBrand.TabIndex = 25;
            this.txtBrand.Text = "Brand";
            this.txtBrand.TextOffsetX = 5;
            this.txtBrand.Enter += new System.EventHandler(this.txtBrand_Enter);
            this.txtBrand.Leave += new System.EventHandler(this.txtBrand_Leave);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Transparent;
            this.txtProductName.BaseColor = System.Drawing.Color.White;
            this.txtProductName.BorderColor = System.Drawing.Color.Black;
            this.txtProductName.BorderSize = 1;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProductName.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtProductName.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtProductName.Location = new System.Drawing.Point(327, 89);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.Radius = 8;
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(160, 30);
            this.txtProductName.TabIndex = 24;
            this.txtProductName.Text = "Product Name";
            this.txtProductName.TextOffsetX = 5;
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // AddProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPriceError);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.lblBrandError);
            this.Controls.Add(this.lblProductNameError);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtProductName);
            this.Name = "AddProductUC";
            this.Size = new System.Drawing.Size(815, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPriceError;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblBrandError;
        private System.Windows.Forms.Label lblProductNameError;
        private Guna.UI.WinForms.GunaButton btnAddProduct;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaTextBox txtBrand;
        private Guna.UI.WinForms.GunaTextBox txtProductName;
    }
}
