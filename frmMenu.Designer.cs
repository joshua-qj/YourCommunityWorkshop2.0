
namespace YourCommunityWorkshop {
    partial class frmMenu {
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(69, 50);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnTool
            // 
            this.btnTool.Location = new System.Drawing.Point(69, 158);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(75, 23);
            this.btnTool.TabIndex = 1;
            this.btnTool.Text = "Tool";
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(69, 284);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(75, 23);
            this.btnRental.TabIndex = 2;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(217, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color Setting";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Location = new System.Drawing.Point(217, 158);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(75, 23);
            this.btnBrand.TabIndex = 4;
            this.btnBrand.Text = "Brand";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBrand);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.btnTool);
            this.Controls.Add(this.btnCustomer);
            this.Name = "frmMenu";
            this.Text = "Your Community Workshop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnExit;
    }
}

