namespace YourCommunityWorkshop {
    partial class frmAvailableTools {
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
            this.dgvAvailableTools = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblToolName = new System.Windows.Forms.Label();
            this.tbxToolBrand = new System.Windows.Forms.TextBox();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTools)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableTools
            // 
            this.dgvAvailableTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableTools.Location = new System.Drawing.Point(12, 12);
            this.dgvAvailableTools.Name = "dgvAvailableTools";
            this.dgvAvailableTools.Size = new System.Drawing.Size(776, 381);
            this.dgvAvailableTools.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(293, 409);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(113, 22);
            this.lblBrand.TabIndex = 27;
            this.lblBrand.Text = "Tool Brand";
            // 
            // lblToolName
            // 
            this.lblToolName.AutoSize = true;
            this.lblToolName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolName.Location = new System.Drawing.Point(8, 409);
            this.lblToolName.Name = "lblToolName";
            this.lblToolName.Size = new System.Drawing.Size(108, 22);
            this.lblToolName.TabIndex = 26;
            this.lblToolName.Text = "Tool Name";
            // 
            // tbxToolBrand
            // 
            this.tbxToolBrand.Location = new System.Drawing.Point(412, 413);
            this.tbxToolBrand.Name = "tbxToolBrand";
            this.tbxToolBrand.Size = new System.Drawing.Size(142, 20);
            this.tbxToolBrand.TabIndex = 25;
            this.tbxToolBrand.TextChanged += new System.EventHandler(this.tbxToolBrand_TextChanged);
            // 
            // tbxToolName
            // 
            this.tbxToolName.Location = new System.Drawing.Point(122, 413);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(148, 20);
            this.tbxToolName.TabIndex = 24;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(598, 413);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmAvailableTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblToolName);
            this.Controls.Add(this.tbxToolBrand);
            this.Controls.Add(this.tbxToolName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAvailableTools);
            this.Name = "frmAvailableTools";
            this.Text = "Available Tools";
            this.Load += new System.EventHandler(this.frmAvailableTools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAvailableTools;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblToolName;
        private System.Windows.Forms.TextBox tbxToolBrand;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.Button btnExport;
    }
}