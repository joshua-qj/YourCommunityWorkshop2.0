
namespace YourCommunityWorkshop {
    partial class frmReturn {
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.tbxCondition = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblToolName = new System.Windows.Forms.Label();
            this.lblCustomerReturnTool = new System.Windows.Forms.Label();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.tbxReturnTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerName.Location = new System.Drawing.Point(31, 102);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(30, 152);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(88, 13);
            this.lblCondition.TabIndex = 2;
            this.lblCondition.Text = "Update condition";
            // 
            // tbxCondition
            // 
            this.tbxCondition.Location = new System.Drawing.Point(140, 152);
            this.tbxCondition.Multiline = true;
            this.tbxCondition.Name = "tbxCondition";
            this.tbxCondition.Size = new System.Drawing.Size(189, 180);
            this.tbxCondition.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(33, 390);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(254, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblToolName
            // 
            this.lblToolName.AutoSize = true;
            this.lblToolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToolName.Location = new System.Drawing.Point(244, 102);
            this.lblToolName.Name = "lblToolName";
            this.lblToolName.Size = new System.Drawing.Size(85, 20);
            this.lblToolName.TabIndex = 6;
            this.lblToolName.Text = "Tool Name";
            // 
            // lblCustomerReturnTool
            // 
            this.lblCustomerReturnTool.AutoSize = true;
            this.lblCustomerReturnTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerReturnTool.Location = new System.Drawing.Point(29, 26);
            this.lblCustomerReturnTool.Name = "lblCustomerReturnTool";
            this.lblCustomerReturnTool.Size = new System.Drawing.Size(289, 33);
            this.lblCustomerReturnTool.TabIndex = 7;
            this.lblCustomerReturnTool.Text = "Customer return tool!";
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.Location = new System.Drawing.Point(32, 361);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(65, 13);
            this.lblReturnTime.TabIndex = 8;
            this.lblReturnTime.Text = "Return Time";
            // 
            // tbxReturnTime
            // 
            this.tbxReturnTime.Location = new System.Drawing.Point(140, 358);
            this.tbxReturnTime.Name = "tbxReturnTime";
            this.tbxReturnTime.Size = new System.Drawing.Size(189, 20);
            this.tbxReturnTime.TabIndex = 9;
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.tbxReturnTime);
            this.Controls.Add(this.lblReturnTime);
            this.Controls.Add(this.lblCustomerReturnTool);
            this.Controls.Add(this.lblToolName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbxCondition);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "frmReturn";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox tbxCondition;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblToolName;
        private System.Windows.Forms.Label lblCustomerReturnTool;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.TextBox tbxReturnTime;
    }
}