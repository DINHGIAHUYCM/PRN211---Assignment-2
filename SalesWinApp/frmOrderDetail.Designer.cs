namespace SalesWinApp
{
    partial class frmOrderDetail
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
            lbOrderID = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            lbMemberID = new System.Windows.Forms.Label();
            txtMemberID = new System.Windows.Forms.TextBox();
            lbOrderDate = new System.Windows.Forms.Label();
            dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            lbRequireDate = new System.Windows.Forms.Label();
            dtpRequireDate = new System.Windows.Forms.DateTimePicker();
            lbShippedDate = new System.Windows.Forms.Label();
            dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            lbFreight = new System.Windows.Forms.Label();
            txtFreight = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(111, 143);
            lbOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(81, 25);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(231, 130);
            txtOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(284, 31);
            txtOrderID.TabIndex = 1;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(94, 223);
            lbMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(102, 25);
            lbMemberID.TabIndex = 2;
            lbMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(231, 218);
            txtMemberID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(284, 31);
            txtMemberID.TabIndex = 3;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(94, 318);
            lbOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(98, 25);
            lbOrderDate.TabIndex = 4;
            lbOrderDate.Text = "Order date";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new System.Drawing.Point(231, 308);
            dtpOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new System.Drawing.Size(284, 31);
            dtpOrderDate.TabIndex = 5;
            // 
            // lbRequireDate
            // 
            lbRequireDate.AutoSize = true;
            lbRequireDate.Location = new System.Drawing.Point(84, 402);
            lbRequireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbRequireDate.Name = "lbRequireDate";
            lbRequireDate.Size = new System.Drawing.Size(111, 25);
            lbRequireDate.TabIndex = 6;
            lbRequireDate.Text = "Require date";
            // 
            // dtpRequireDate
            // 
            dtpRequireDate.Location = new System.Drawing.Point(231, 392);
            dtpRequireDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpRequireDate.Name = "dtpRequireDate";
            dtpRequireDate.Size = new System.Drawing.Size(284, 31);
            dtpRequireDate.TabIndex = 7;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new System.Drawing.Point(76, 473);
            lbShippedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new System.Drawing.Size(118, 25);
            lbShippedDate.TabIndex = 8;
            lbShippedDate.Text = "Shipped date";
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new System.Drawing.Point(231, 460);
            dtpShippedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new System.Drawing.Size(284, 31);
            dtpShippedDate.TabIndex = 9;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new System.Drawing.Point(111, 550);
            lbFreight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new System.Drawing.Size(67, 25);
            lbFreight.TabIndex = 10;
            lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new System.Drawing.Point(231, 543);
            txtFreight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new System.Drawing.Size(284, 31);
            txtFreight.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Lime;
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(166, 655);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(107, 38);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Red;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(360, 655);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(107, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(77, 33);
            lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(257, 54);
            lbTitle.TabIndex = 67;
            lbTitle.Text = "Order Details";
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(634, 750);
            Controls.Add(lbTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFreight);
            Controls.Add(lbFreight);
            Controls.Add(dtpShippedDate);
            Controls.Add(lbShippedDate);
            Controls.Add(dtpRequireDate);
            Controls.Add(lbRequireDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmOrderDetail";
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lbRequireDate;
        private System.Windows.Forms.DateTimePicker dtpRequireDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTitle;
    }
}