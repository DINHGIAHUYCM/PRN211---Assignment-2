namespace SalesWinApp
{
    partial class frmOrder
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
            dgvOrder = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new System.Drawing.Point(324, 15);
            dgvOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new System.Drawing.Size(960, 533);
            dgvOrder.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Red;
            btnDelete.Location = new System.Drawing.Point(90, 277);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(117, 37);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.LimeGreen;
            btnCreate.Location = new System.Drawing.Point(90, 115);
            btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(107, 38);
            btnCreate.TabIndex = 49;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.Gold;
            btnUpdate.Location = new System.Drawing.Point(90, 190);
            btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(107, 38);
            btnUpdate.TabIndex = 50;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(90, 30);
            lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(126, 54);
            lbTitle.TabIndex = 67;
            lbTitle.Text = "Order";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1322, 563);
            Controls.Add(lbTitle);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(dgvOrder);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbTitle;
    }
}