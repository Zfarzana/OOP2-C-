namespace ArtShopManagementSystem
{
    partial class CartUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.P_IDcart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantityCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Increment = new System.Windows.Forms.DataGridViewImageColumn();
            this.Decrement = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.empty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnCheckout = new Guna.UI.WinForms.GunaButton();
            this.btnClearCart = new Guna.UI.WinForms.GunaButton();
            this.lblInvalidLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(445, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 49);
            this.panel1.TabIndex = 49;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(196, 11);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(56, 25);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "0.00$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(7, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(183, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Amount to be paid : ";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_IDcart,
            this.ProductNameCart,
            this.PriceCart,
            this.QuantityCart,
            this.TotalQuantityCart,
            this.Increment,
            this.Decrement,
            this.DeleteButton,
            this.empty});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCart.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCart.Location = new System.Drawing.Point(445, 23);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 15;
            this.dgvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvCart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvCart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCart.RowTemplate.Height = 40;
            this.dgvCart.RowTemplate.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(339, 231);
            this.dgvCart.TabIndex = 48;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // P_IDcart
            // 
            this.P_IDcart.HeaderText = "";
            this.P_IDcart.Name = "P_IDcart";
            this.P_IDcart.ReadOnly = true;
            this.P_IDcart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.P_IDcart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_IDcart.Visible = false;
            // 
            // ProductNameCart
            // 
            this.ProductNameCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductNameCart.DefaultCellStyle = dataGridViewCellStyle17;
            this.ProductNameCart.FillWeight = 32.25807F;
            this.ProductNameCart.HeaderText = "Name";
            this.ProductNameCart.Name = "ProductNameCart";
            this.ProductNameCart.ReadOnly = true;
            this.ProductNameCart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductNameCart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceCart
            // 
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.PriceCart.DefaultCellStyle = dataGridViewCellStyle18;
            this.PriceCart.HeaderText = "Price";
            this.PriceCart.Name = "PriceCart";
            this.PriceCart.ReadOnly = true;
            this.PriceCart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PriceCart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PriceCart.Width = 70;
            // 
            // QuantityCart
            // 
            this.QuantityCart.FillWeight = 167.7419F;
            this.QuantityCart.HeaderText = "Quantity";
            this.QuantityCart.Name = "QuantityCart";
            this.QuantityCart.ReadOnly = true;
            this.QuantityCart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuantityCart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QuantityCart.Width = 70;
            // 
            // TotalQuantityCart
            // 
            this.TotalQuantityCart.HeaderText = "";
            this.TotalQuantityCart.Name = "TotalQuantityCart";
            this.TotalQuantityCart.ReadOnly = true;
            this.TotalQuantityCart.Visible = false;
            // 
            // Increment
            // 
            this.Increment.HeaderText = "";
            this.Increment.Image = ((System.Drawing.Image)(resources.GetObject("Increment.Image")));
            this.Increment.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Increment.Name = "Increment";
            this.Increment.ReadOnly = true;
            this.Increment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Increment.Width = 35;
            // 
            // Decrement
            // 
            this.Decrement.HeaderText = "";
            this.Decrement.Image = ((System.Drawing.Image)(resources.GetObject("Decrement.Image")));
            this.Decrement.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Decrement.Name = "Decrement";
            this.Decrement.ReadOnly = true;
            this.Decrement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Decrement.Width = 35;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteButton.Width = 35;
            // 
            // empty
            // 
            this.empty.HeaderText = "";
            this.empty.Name = "empty";
            this.empty.ReadOnly = true;
            this.empty.Width = 5;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.ProductName,
            this.Brand,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvProduct.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvProduct.Location = new System.Drawing.Point(33, 115);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 15;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduct.RowTemplate.Height = 40;
            this.dgvProduct.RowTemplate.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(339, 276);
            this.dgvProduct.TabIndex = 45;
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "P_ID";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.P_ID.DefaultCellStyle = dataGridViewCellStyle24;
            this.P_ID.HeaderText = "ID";
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            this.P_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.P_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_ID.Width = 55;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle25;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Brand.Visible = false;
            this.Brand.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 80;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(33, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(339, 30);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.Text = "Search By ID";
            this.txtSearch.TextOffsetX = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AnimationHoverSpeed = 0.07F;
            this.btnCheckout.AnimationSpeed = 0.03F;
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.BaseColor = System.Drawing.Color.White;
            this.btnCheckout.BorderColor = System.Drawing.Color.Black;
            this.btnCheckout.BorderSize = 1;
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckout.FocusedColor = System.Drawing.Color.Empty;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.Image = null;
            this.btnCheckout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCheckout.Location = new System.Drawing.Point(624, 349);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnCheckout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCheckout.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnCheckout.OnHoverImage = null;
            this.btnCheckout.OnPressedColor = System.Drawing.Color.Black;
            this.btnCheckout.Radius = 8;
            this.btnCheckout.Size = new System.Drawing.Size(160, 42);
            this.btnCheckout.TabIndex = 50;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.AnimationHoverSpeed = 0.07F;
            this.btnClearCart.AnimationSpeed = 0.03F;
            this.btnClearCart.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCart.BaseColor = System.Drawing.Color.White;
            this.btnClearCart.BorderColor = System.Drawing.Color.Black;
            this.btnClearCart.BorderSize = 1;
            this.btnClearCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.Color.Black;
            this.btnClearCart.Image = null;
            this.btnClearCart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClearCart.Location = new System.Drawing.Point(445, 349);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnClearCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClearCart.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClearCart.OnHoverImage = null;
            this.btnClearCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearCart.Radius = 8;
            this.btnClearCart.Size = new System.Drawing.Size(160, 42);
            this.btnClearCart.TabIndex = 51;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // lblInvalidLogin
            // 
            this.lblInvalidLogin.AutoSize = true;
            this.lblInvalidLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidLogin.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidLogin.Location = new System.Drawing.Point(82, 77);
            this.lblInvalidLogin.Name = "lblInvalidLogin";
            this.lblInvalidLogin.Size = new System.Drawing.Size(230, 13);
            this.lblInvalidLogin.TabIndex = 52;
            this.lblInvalidLogin.Text = "Double Click To Add Product In The Cart";
            // 
            // CartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInvalidLogin);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.dgvProduct);
            this.Name = "CartUC";
            this.Size = new System.Drawing.Size(815, 418);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridView dgvProduct;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private Guna.UI.WinForms.GunaButton btnCheckout;
        private Guna.UI.WinForms.GunaButton btnClearCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_IDcart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantityCart;
        private System.Windows.Forms.DataGridViewImageColumn Increment;
        private System.Windows.Forms.DataGridViewImageColumn Decrement;
        private System.Windows.Forms.DataGridViewImageColumn DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn empty;
        private System.Windows.Forms.Label lblInvalidLogin;
    }
}
