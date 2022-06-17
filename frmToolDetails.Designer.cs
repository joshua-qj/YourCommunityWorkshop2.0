
namespace YourCommunityWorkshop {
    partial class frmToolDetails {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblToolName = new System.Windows.Forms.Label();
            this.lblSerialNO = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxSerialNO = new System.Windows.Forms.TextBox();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.tbxCondition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(141, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblToolName
            // 
            this.lblToolName.AutoSize = true;
            this.lblToolName.Location = new System.Drawing.Point(24, 50);
            this.lblToolName.Name = "lblToolName";
            this.lblToolName.Size = new System.Drawing.Size(59, 13);
            this.lblToolName.TabIndex = 2;
            this.lblToolName.Text = "Tool Name";
            // 
            // lblSerialNO
            // 
            this.lblSerialNO.AutoSize = true;
            this.lblSerialNO.Location = new System.Drawing.Point(24, 99);
            this.lblSerialNO.Name = "lblSerialNO";
            this.lblSerialNO.Size = new System.Drawing.Size(52, 13);
            this.lblSerialNO.TabIndex = 3;
            this.lblSerialNO.Text = "Serial NO";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(24, 151);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Brand";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 208);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // tbxSerialNO
            // 
            this.tbxSerialNO.Location = new System.Drawing.Point(101, 92);
            this.tbxSerialNO.Name = "tbxSerialNO";
            this.tbxSerialNO.Size = new System.Drawing.Size(121, 20);
            this.tbxSerialNO.TabIndex = 8;
            // 
            // tbxToolName
            // 
            this.tbxToolName.Location = new System.Drawing.Point(101, 47);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(121, 20);
            this.tbxToolName.TabIndex = 9;
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(101, 148);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(121, 21);
            this.cboBrand.TabIndex = 10;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(101, 208);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 11;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(24, 271);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(51, 13);
            this.lblCondition.TabIndex = 12;
            this.lblCondition.Text = "Condition";
            // 
            // tbxCondition
            // 
            this.tbxCondition.Location = new System.Drawing.Point(101, 264);
            this.tbxCondition.Multiline = true;
            this.tbxCondition.Name = "tbxCondition";
            this.tbxCondition.Size = new System.Drawing.Size(121, 82);
            this.tbxCondition.TabIndex = 13;
            // 
            // frmToolDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 425);
            this.Controls.Add(this.tbxCondition);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.tbxToolName);
            this.Controls.Add(this.tbxSerialNO);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblSerialNO);
            this.Controls.Add(this.lblToolName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmToolDetails";
            this.Text = "Tool Details";
            this.Load += new System.EventHandler(this.frmToolDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblToolName;
        private System.Windows.Forms.Label lblSerialNO;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxSerialNO;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox tbxCondition;
    }
}