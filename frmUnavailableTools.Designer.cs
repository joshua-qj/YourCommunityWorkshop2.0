namespace YourCommunityWorkshop {
    partial class frmUnavailableTools {
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
            this.btnExport = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblToolName = new System.Windows.Forms.Label();
            this.tbxToolBrand = new System.Windows.Forms.TextBox();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvUnavailableTools = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnavailableTools)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(600, 414);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 35;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(295, 410);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(113, 22);
            this.lblBrand.TabIndex = 34;
            this.lblBrand.Text = "Tool Brand";
            // 
            // lblToolName
            // 
            this.lblToolName.AutoSize = true;
            this.lblToolName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolName.Location = new System.Drawing.Point(10, 410);
            this.lblToolName.Name = "lblToolName";
            this.lblToolName.Size = new System.Drawing.Size(108, 22);
            this.lblToolName.TabIndex = 33;
            this.lblToolName.Text = "Tool Name";
            // 
            // tbxToolBrand
            // 
            this.tbxToolBrand.Location = new System.Drawing.Point(414, 414);
            this.tbxToolBrand.Name = "tbxToolBrand";
            this.tbxToolBrand.Size = new System.Drawing.Size(142, 20);
            this.tbxToolBrand.TabIndex = 32;
            this.tbxToolBrand.TextChanged += new System.EventHandler(this.tbxToolBrand_TextChanged);
            // 
            // tbxToolName
            // 
            this.tbxToolName.Location = new System.Drawing.Point(124, 414);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(148, 20);
            this.tbxToolName.TabIndex = 31;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(715, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvUnavailableTools
            // 
            this.dgvUnavailableTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnavailableTools.Location = new System.Drawing.Point(14, 13);
            this.dgvUnavailableTools.Name = "dgvUnavailableTools";
            this.dgvUnavailableTools.Size = new System.Drawing.Size(776, 381);
            this.dgvUnavailableTools.TabIndex = 29;
            // 
            // frmUnavailableTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblToolName);
            this.Controls.Add(this.tbxToolBrand);
            this.Controls.Add(this.tbxToolName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvUnavailableTools);
            this.Name = "frmUnavailableTools";
            this.Text = "frmUnavailableTools";
            this.Load += new System.EventHandler(this.frmUnavailableTools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnavailableTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblToolName;
        private System.Windows.Forms.TextBox tbxToolBrand;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvUnavailableTools;
    }
}