namespace ArtShopManagementSystem
{
    partial class AddEmployeeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeUC));
            this.txtFullName = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtSalary = new Guna.UI.WinForms.GunaTextBox();
            this.rbtnMale = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.rbtnFemale = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.btnAddSeller = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFullnameError = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblSalaryError = new System.Windows.Forms.Label();
            this.lblMaleError = new System.Windows.Forms.Label();
            this.lblFemaleError = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.txtFullName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFullName.Location = new System.Drawing.Point(327, 34);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.Radius = 8;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(160, 30);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.Text = "Full Name";
            this.txtFullName.TextOffsetX = 5;
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsername.Location = new System.Drawing.Point(327, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 8;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(160, 30);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextOffsetX = 5;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
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
            this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPassword.Location = new System.Drawing.Point(327, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 8;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(160, 30);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextOffsetX = 5;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
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
            this.txtPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPhone.Location = new System.Drawing.Point(327, 176);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 8;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(160, 30);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Text = "Phone Number";
            this.txtPhone.TextOffsetX = 5;
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
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
            this.txtSalary.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSalary.Location = new System.Drawing.Point(327, 224);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.Radius = 8;
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(160, 30);
            this.txtSalary.TabIndex = 10;
            this.txtSalary.Text = "Salary";
            this.txtSalary.TextOffsetX = 5;
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // rbtnMale
            // 
            this.rbtnMale.BaseColor = System.Drawing.Color.White;
            this.rbtnMale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtnMale.CheckedOnColor = System.Drawing.Color.Black;
            this.rbtnMale.FillColor = System.Drawing.Color.White;
            this.rbtnMale.Location = new System.Drawing.Point(351, 287);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(20, 20);
            this.rbtnMale.TabIndex = 11;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.BaseColor = System.Drawing.Color.White;
            this.rbtnFemale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtnFemale.CheckedOnColor = System.Drawing.Color.Black;
            this.rbtnFemale.FillColor = System.Drawing.Color.White;
            this.rbtnFemale.Location = new System.Drawing.Point(509, 287);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(20, 20);
            this.rbtnFemale.TabIndex = 12;
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
            this.btnClear.Location = new System.Drawing.Point(277, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 8;
            this.btnClear.Size = new System.Drawing.Size(119, 42);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.AnimationHoverSpeed = 0.07F;
            this.btnAddSeller.AnimationSpeed = 0.03F;
            this.btnAddSeller.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSeller.BaseColor = System.Drawing.Color.White;
            this.btnAddSeller.BorderColor = System.Drawing.Color.Black;
            this.btnAddSeller.BorderSize = 1;
            this.btnAddSeller.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSeller.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddSeller.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeller.ForeColor = System.Drawing.Color.Black;
            this.btnAddSeller.Image = null;
            this.btnAddSeller.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddSeller.Location = new System.Drawing.Point(419, 343);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddSeller.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddSeller.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddSeller.OnHoverImage = null;
            this.btnAddSeller.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddSeller.Radius = 8;
            this.btnAddSeller.Size = new System.Drawing.Size(119, 42);
            this.btnAddSeller.TabIndex = 14;
            this.btnAddSeller.Text = "Add Seller";
            this.btnAddSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(285, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(442, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 16;
            // 
            // lblFullnameError
            // 
            this.lblFullnameError.AutoSize = true;
            this.lblFullnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullnameError.ForeColor = System.Drawing.Color.Red;
            this.lblFullnameError.Location = new System.Drawing.Point(506, 40);
            this.lblFullnameError.Name = "lblFullnameError";
            this.lblFullnameError.Size = new System.Drawing.Size(21, 25);
            this.lblFullnameError.TabIndex = 17;
            this.lblFullnameError.Text = "*";
            this.lblFullnameError.Visible = false;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(506, 88);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(21, 25);
            this.lblUsernameError.TabIndex = 18;
            this.lblUsernameError.Text = "*";
            this.lblUsernameError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(506, 135);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(21, 25);
            this.lblPasswordError.TabIndex = 19;
            this.lblPasswordError.Text = "*";
            this.lblPasswordError.Visible = false;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(506, 181);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(21, 25);
            this.lblPhoneError.TabIndex = 20;
            this.lblPhoneError.Text = "*";
            this.lblPhoneError.Visible = false;
            // 
            // lblSalaryError
            // 
            this.lblSalaryError.AutoSize = true;
            this.lblSalaryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryError.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryError.Location = new System.Drawing.Point(506, 229);
            this.lblSalaryError.Name = "lblSalaryError";
            this.lblSalaryError.Size = new System.Drawing.Size(21, 25);
            this.lblSalaryError.TabIndex = 21;
            this.lblSalaryError.Text = "*";
            this.lblSalaryError.Visible = false;
            // 
            // lblMaleError
            // 
            this.lblMaleError.AutoSize = true;
            this.lblMaleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaleError.ForeColor = System.Drawing.Color.Red;
            this.lblMaleError.Location = new System.Drawing.Point(382, 288);
            this.lblMaleError.Name = "lblMaleError";
            this.lblMaleError.Size = new System.Drawing.Size(21, 25);
            this.lblMaleError.TabIndex = 22;
            this.lblMaleError.Text = "*";
            this.lblMaleError.Visible = false;
            // 
            // lblFemaleError
            // 
            this.lblFemaleError.AutoSize = true;
            this.lblFemaleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleError.ForeColor = System.Drawing.Color.Red;
            this.lblFemaleError.Location = new System.Drawing.Point(540, 288);
            this.lblFemaleError.Name = "lblFemaleError";
            this.lblFemaleError.Size = new System.Drawing.Size(21, 25);
            this.lblFemaleError.TabIndex = 23;
            this.lblFemaleError.Text = "*";
            this.lblFemaleError.Visible = false;
            // 
            // AddEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFemaleError);
            this.Controls.Add(this.lblMaleError);
            this.Controls.Add(this.lblSalaryError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.lblFullnameError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddSeller);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFullName);
            this.Name = "AddEmployeeUC";
            this.Size = new System.Drawing.Size(815, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtFullName;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaTextBox txtSalary;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtnMale;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtnFemale;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaButton btnAddSeller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFullnameError;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblSalaryError;
        private System.Windows.Forms.Label lblMaleError;
        private System.Windows.Forms.Label lblFemaleError;
    }
}
