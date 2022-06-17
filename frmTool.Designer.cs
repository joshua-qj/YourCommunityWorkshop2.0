
namespace YourCommunityWorkshop {
    partial class frmTool {
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTool = new System.Windows.Forms.DataGridView();
            this.btnAvailableTools = new System.Windows.Forms.Button();
            this.btnUnavailableTools = new System.Windows.Forms.Button();
            this.btnRetiredTools = new System.Windows.Forms.Button();
            this.btnActiveTools = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTool)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(599, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTool
            // 
            this.dgvTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTool.Location = new System.Drawing.Point(12, 12);
            this.dgvTool.Name = "dgvTool";
            this.dgvTool.Size = new System.Drawing.Size(660, 295);
            this.dgvTool.TabIndex = 6;
            this.dgvTool.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTool_CellContentDoubleClick);
            // 
            // btnAvailableTools
            // 
            this.btnAvailableTools.Location = new System.Drawing.Point(688, 36);
            this.btnAvailableTools.Name = "btnAvailableTools";
            this.btnAvailableTools.Size = new System.Drawing.Size(75, 42);
            this.btnAvailableTools.TabIndex = 7;
            this.btnAvailableTools.Text = "Available Tools ";
            this.btnAvailableTools.UseVisualStyleBackColor = true;
            this.btnAvailableTools.Click += new System.EventHandler(this.btnAvailableTools_Click);
            // 
            // btnUnavailableTools
            // 
            this.btnUnavailableTools.Location = new System.Drawing.Point(688, 111);
            this.btnUnavailableTools.Name = "btnUnavailableTools";
            this.btnUnavailableTools.Size = new System.Drawing.Size(75, 41);
            this.btnUnavailableTools.TabIndex = 8;
            this.btnUnavailableTools.Text = "Unavailable Tools";
            this.btnUnavailableTools.UseVisualStyleBackColor = true;
            this.btnUnavailableTools.Click += new System.EventHandler(this.btnUnavailableTools_Click);
            // 
            // btnRetiredTools
            // 
            this.btnRetiredTools.Location = new System.Drawing.Point(688, 191);
            this.btnRetiredTools.Name = "btnRetiredTools";
            this.btnRetiredTools.Size = new System.Drawing.Size(75, 35);
            this.btnRetiredTools.TabIndex = 9;
            this.btnRetiredTools.Text = "Retired Tools";
            this.btnRetiredTools.UseVisualStyleBackColor = true;
            this.btnRetiredTools.Click += new System.EventHandler(this.btnRetiredTools_Click);
            // 
            // btnActiveTools
            // 
            this.btnActiveTools.Location = new System.Drawing.Point(688, 264);
            this.btnActiveTools.Name = "btnActiveTools";
            this.btnActiveTools.Size = new System.Drawing.Size(75, 43);
            this.btnActiveTools.TabIndex = 10;
            this.btnActiveTools.Text = "Active Tools";
            this.btnActiveTools.UseVisualStyleBackColor = true;
            this.btnActiveTools.Click += new System.EventHandler(this.btnActiveTools_Click);
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReport.Location = new System.Drawing.Point(683, 9);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(82, 25);
            this.lblReport.TabIndex = 11;
            this.lblReport.Text = "Report";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 397);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.btnActiveTools);
            this.Controls.Add(this.btnRetiredTools);
            this.Controls.Add(this.btnUnavailableTools);
            this.Controls.Add(this.btnAvailableTools);
            this.Controls.Add(this.dgvTool);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmTool";
            this.Text = "Tool";
            this.Load += new System.EventHandler(this.frmTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTool;
        private System.Windows.Forms.Button btnAvailableTools;
        private System.Windows.Forms.Button btnUnavailableTools;
        private System.Windows.Forms.Button btnRetiredTools;
        private System.Windows.Forms.Button btnActiveTools;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}