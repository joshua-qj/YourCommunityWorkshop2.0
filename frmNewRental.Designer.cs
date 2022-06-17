
namespace YourCommunityWorkshop {
    partial class frmNewRental {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRentalTime = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboTool = new System.Windows.Forms.ComboBox();
            this.tbxRentalTime = new System.Windows.Forms.TextBox();
            this.lblToolCondition = new System.Windows.Forms.Label();
            this.tbxToolCondition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(236, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tool";
            // 
            // lblRentalTime
            // 
            this.lblRentalTime.AutoSize = true;
            this.lblRentalTime.Location = new System.Drawing.Point(40, 296);
            this.lblRentalTime.Name = "lblRentalTime";
            this.lblRentalTime.Size = new System.Drawing.Size(64, 13);
            this.lblRentalTime.TabIndex = 4;
            this.lblRentalTime.Text = "Rental Time";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(142, 39);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(169, 21);
            this.cboCustomer.TabIndex = 7;
            // 
            // cboTool
            // 
            this.cboTool.FormattingEnabled = true;
            this.cboTool.Location = new System.Drawing.Point(142, 126);
            this.cboTool.Name = "cboTool";
            this.cboTool.Size = new System.Drawing.Size(169, 21);
            this.cboTool.TabIndex = 8;
            this.cboTool.SelectedIndexChanged += new System.EventHandler(this.cboTool_SelectedIndexChanged);
            // 
            // tbxRentalTime
            // 
            this.tbxRentalTime.Location = new System.Drawing.Point(142, 289);
            this.tbxRentalTime.Name = "tbxRentalTime";
            this.tbxRentalTime.Size = new System.Drawing.Size(169, 20);
            this.tbxRentalTime.TabIndex = 9;
            // 
            // lblToolCondition
            // 
            this.lblToolCondition.AutoSize = true;
            this.lblToolCondition.Location = new System.Drawing.Point(40, 203);
            this.lblToolCondition.Name = "lblToolCondition";
            this.lblToolCondition.Size = new System.Drawing.Size(75, 13);
            this.lblToolCondition.TabIndex = 10;
            this.lblToolCondition.Text = "Tool Condition";
            // 
            // tbxToolCondition
            // 
            this.tbxToolCondition.Location = new System.Drawing.Point(142, 203);
            this.tbxToolCondition.Multiline = true;
            this.tbxToolCondition.Name = "tbxToolCondition";
            this.tbxToolCondition.Size = new System.Drawing.Size(169, 65);
            this.tbxToolCondition.TabIndex = 11;
            // 
            // frmNewRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.tbxToolCondition);
            this.Controls.Add(this.lblToolCondition);
            this.Controls.Add(this.tbxRentalTime);
            this.Controls.Add(this.cboTool);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblRentalTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmNewRental";
            this.Text = "New Rental";
            this.Load += new System.EventHandler(this.frmNewRental_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRentalTime;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboTool;
        private System.Windows.Forms.TextBox tbxRentalTime;
        private System.Windows.Forms.Label lblToolCondition;
        private System.Windows.Forms.TextBox tbxToolCondition;
    }
}