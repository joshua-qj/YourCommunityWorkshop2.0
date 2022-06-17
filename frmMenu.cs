using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourCommunityWorkshop {
    public partial class frmMenu : Form {
        public frmMenu() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
        }

        private void btnColor_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            //colorDialog.AllowFullOpen = true;
            //colorDialog.AnyColor = true;
            //colorDialog.SolidColorOnly = true;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.Setting = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
            this.BackColor = Properties.Settings.Default.Setting;
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
        }

        private void btnTool_Click(object sender, EventArgs e) {
            frmTool frm = new frmTool();
            frm.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e) {
            frmBrands frm = new frmBrands();
            frm.ShowDialog();
        }

   

        private void btnRental_Click(object sender, EventArgs e) {
            var frm = new frmRental();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
