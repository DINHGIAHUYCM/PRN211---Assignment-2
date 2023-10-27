namespace SalesWinApp
{
    partial class frmMemberDetail
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
            txtPassword = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            lbMemberID = new System.Windows.Forms.Label();
            lbCompanyName = new System.Windows.Forms.Label();
            txtCmName = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            lbCategoryName = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(218, 324);
            txtPassword.Margin = new System.Windows.Forms.Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(233, 31);
            txtPassword.TabIndex = 64;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(218, 118);
            txtMemberID.Margin = new System.Windows.Forms.Padding(4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(233, 31);
            txtMemberID.TabIndex = 63;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(84, 126);
            lbMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(102, 25);
            lbMemberID.TabIndex = 62;
            lbMemberID.Text = "Member ID";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(38, 200);
            lbCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(141, 25);
            lbCompanyName.TabIndex = 61;
            lbCompanyName.Text = "Company Name";
            // 
            // txtCmName
            // 
            txtCmName.Location = new System.Drawing.Point(218, 200);
            txtCmName.Margin = new System.Windows.Forms.Padding(4);
            txtCmName.Name = "txtCmName";
            txtCmName.Size = new System.Drawing.Size(233, 31);
            txtCmName.TabIndex = 60;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(218, 282);
            txtCountry.Margin = new System.Windows.Forms.Padding(4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(233, 31);
            txtCountry.TabIndex = 59;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(218, 241);
            txtCity.Margin = new System.Windows.Forms.Padding(4);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(233, 31);
            txtCity.TabIndex = 58;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(218, 159);
            txtEmail.Margin = new System.Windows.Forms.Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(233, 31);
            txtEmail.TabIndex = 57;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(104, 282);
            lbCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(75, 25);
            lbCountry.TabIndex = 56;
            lbCountry.Text = "Country";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new System.Drawing.Point(91, 324);
            lbCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new System.Drawing.Size(87, 25);
            lbCategoryName.TabIndex = 55;
            lbCategoryName.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(136, 241);
            lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(42, 25);
            lbCity.TabIndex = 54;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(125, 162);
            lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(54, 25);
            lbEmail.TabIndex = 53;
            lbEmail.Text = "Email";
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.LimeGreen;
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(125, 416);
            btnSave.Margin = new System.Windows.Forms.Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(118, 36);
            btnSave.TabIndex = 65;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(38, 29);
            lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(304, 54);
            lbTitle.TabIndex = 66;
            lbTitle.Text = "Member Details";
            lbTitle.Click += lbTitle_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.Location = new System.Drawing.Point(301, 416);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 36);
            button1.TabIndex = 67;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(530, 521);
            Controls.Add(button1);
            Controls.Add(lbTitle);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Controls.Add(lbCompanyName);
            Controls.Add(txtCmName);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(lbCountry);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmMemberDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCmName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCategoryName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button1;
    }
}