namespace ArtShopManagementSystem
{
    partial class EditEmployeeInfoUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lblGenderError = new System.Windows.Forms.Label();
            this.lblSalaryError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblFullnameError = new System.Windows.Forms.Label();
            this.btnSaveInfo = new Guna.UI.WinForms.GunaButton();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.txtSalary = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtFullName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGender = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInvalidLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_ID,
            this.Password,
            this.Username,
            this.FullName,
            this.Phone,
            this.Gender,
            this.Salary,
            this.JoiningDate});
            this.dgvEmployee.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.Location = new System.Drawing.Point(19, 117);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 15;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployee.RowTemplate.Height = 40;
            this.dgvEmployee.RowTemplate.ReadOnly = true;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(363, 281);
            this.dgvEmployee.TabIndex = 22;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.U_ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.U_ID.HeaderText = "ID";
            this.U_ID.Name = "U_ID";
            this.U_ID.ReadOnly = true;
            this.U_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.U_ID.Width = 80;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Username.DefaultCellStyle = dataGridViewCellStyle5;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Username.Width = 120;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.FullName.DefaultCellStyle = dataGridViewCellStyle6;
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Visible = false;
            // 
            // JoiningDate
            // 
            this.JoiningDate.DataPropertyName = "JoiningDate";
            this.JoiningDate.HeaderText = "JoiningDate";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            this.JoiningDate.Visible = false;
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
            this.txtSearch.Location = new System.Drawing.Point(19, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(363, 30);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.Text = "Search By ID";
            this.txtSearch.TextOffsetX = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblGenderError
            // 
            this.lblGenderError.AutoSize = true;
            this.lblGenderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderError.ForeColor = System.Drawing.Color.Red;
            this.lblGenderError.Location = new System.Drawing.Point(670, 298);
            this.lblGenderError.Name = "lblGenderError";
            this.lblGenderError.Size = new System.Drawing.Size(21, 25);
            this.lblGenderError.TabIndex = 41;
            this.lblGenderError.Text = "*";
            this.lblGenderError.Visible = false;
            // 
            // lblSalaryError
            // 
            this.lblSalaryError.AutoSize = true;
            this.lblSalaryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryError.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryError.Location = new System.Drawing.Point(670, 240);
            this.lblSalaryError.Name = "lblSalaryError";
            this.lblSalaryError.Size = new System.Drawing.Size(21, 25);
            this.lblSalaryError.TabIndex = 39;
            this.lblSalaryError.Text = "*";
            this.lblSalaryError.Visible = false;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(670, 181);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(21, 25);
            this.lblPhoneError.TabIndex = 38;
            this.lblPhoneError.Text = "*";
            this.lblPhoneError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(670, 122);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(21, 25);
            this.lblPasswordError.TabIndex = 37;
            this.lblPasswordError.Text = "*";
            this.lblPasswordError.Visible = false;
            // 
            // lblFullnameError
            // 
            this.lblFullnameError.AutoSize = true;
            this.lblFullnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullnameError.ForeColor = System.Drawing.Color.Red;
            this.lblFullnameError.Location = new System.Drawing.Point(670, 64);
            this.lblFullnameError.Name = "lblFullnameError";
            this.lblFullnameError.Size = new System.Drawing.Size(21, 25);
            this.lblFullnameError.TabIndex = 35;
            this.lblFullnameError.Text = "*";
            this.lblFullnameError.Visible = false;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.AnimationHoverSpeed = 0.07F;
            this.btnSaveInfo.AnimationSpeed = 0.03F;
            this.btnSaveInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveInfo.BaseColor = System.Drawing.Color.White;
            this.btnSaveInfo.BorderColor = System.Drawing.Color.Black;
            this.btnSaveInfo.BorderSize = 1;
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveInfo.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInfo.ForeColor = System.Drawing.Color.Black;
            this.btnSaveInfo.Image = null;
            this.btnSaveInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveInfo.Location = new System.Drawing.Point(585, 356);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSaveInfo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveInfo.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSaveInfo.OnHoverImage = null;
            this.btnSaveInfo.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveInfo.Radius = 8;
            this.btnSaveInfo.Size = new System.Drawing.Size(119, 42);
            this.btnSaveInfo.TabIndex = 32;
            this.btnSaveInfo.Text = "Save Info";
            this.btnSaveInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
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
            this.btnClear.Location = new System.Drawing.Point(443, 356);
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
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Transparent;
            this.txtSalary.BaseColor = System.Drawing.Color.White;
            this.txtSalary.BorderColor = System.Drawing.Color.Black;
            this.txtSalary.BorderSize = 1;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSalary.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtSalary.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.Black;
            this.txtSalary.Location = new System.Drawing.Point(491, 235);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.Radius = 8;
            this.txtSalary.ReadOnly = true;
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(160, 30);
            this.txtSalary.TabIndex = 28;
            this.txtSalary.TextOffsetX = 5;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Black;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(491, 176);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 8;
            this.txtPhone.ReadOnly = true;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(160, 30);
            this.txtPhone.TabIndex = 27;
            this.txtPhone.TextOffsetX = 5;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(491, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 8;
            this.txtPassword.ReadOnly = true;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(160, 30);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.TextOffsetX = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BaseColor = System.Drawing.Color.White;
            this.txtFullName.BorderColor = System.Drawing.Color.Black;
            this.txtFullName.BorderSize = 1;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFullName.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtFullName.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(491, 58);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.Radius = 8;
            this.txtFullName.ReadOnly = true;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(160, 30);
            this.txtFullName.TabIndex = 24;
            this.txtFullName.TextOffsetX = 5;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Salary";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.BaseColor = System.Drawing.Color.White;
            this.cmbGender.BorderColor = System.Drawing.Color.Black;
            this.cmbGender.BorderSize = 1;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Enabled = false;
            this.cmbGender.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(491, 297);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.cmbGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbGender.Radius = 8;
            this.cmbGender.Size = new System.Drawing.Size(160, 26);
            this.cmbGender.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Gender";
            // 
            // lblInvalidLogin
            // 
            this.lblInvalidLogin.AutoSize = true;
            this.lblInvalidLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidLogin.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidLogin.Location = new System.Drawing.Point(107, 78);
            this.lblInvalidLogin.Name = "lblInvalidLogin";
            this.lblInvalidLogin.Size = new System.Drawing.Size(148, 13);
            this.lblInvalidLogin.TabIndex = 48;
            this.lblInvalidLogin.Text = "Double Click To Load Info";
            this.lblInvalidLogin.Click += new System.EventHandler(this.lblInvalidLogin_Click);
            // 
            // EditEmployeeInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInvalidLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGenderError);
            this.Controls.Add(this.lblSalaryError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblFullnameError);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "EditEmployeeInfoUC";
            this.Size = new System.Drawing.Size(815, 418);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.Label lblGenderError;
        private System.Windows.Forms.Label lblSalaryError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblFullnameError;
        private Guna.UI.WinForms.GunaButton btnSaveInfo;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaTextBox txtSalary;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInvalidLogin;
    }
}
