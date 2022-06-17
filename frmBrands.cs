
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagement;

namespace YourCommunityWorkshop {
    public partial class frmBrands : Form {
        List<Brand> brandList = new List<Brand>();
        DatabaseManagement.Adapter adapter = new Adapter();
        public frmBrands() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTable();
        }
        #region Button Event
        private void btnNew_Click(object sender, EventArgs e) {
            var frm = new frmBrandDetails();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }
        #endregion
        #region SetupMethod
        private void SetupDataTable() {
            brandList = adapter.GetAllDataFromTable<Brand>("tblBrands");
            dgvBrand.DataSource = null;
            dgvBrand.DataSource = brandList;
            dgvBrand.Columns["brandId"].Visible = false;//Hides selected column
            dgvBrand.Columns["brandName"].HeaderText = "Brand";
            dgvBrand.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        }
        #endregion
        #region DGV Event
        private void dgvBrand_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int id = (int)dgvBrand["brandId", dgvBrand.CurrentCell.RowIndex].Value;
            frmBrandDetails frm = new frmBrandDetails(id);
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvBrand.Rows.Count > 0) {
                int id = (int)dgvBrand["BrandId", dgvBrand.CurrentCell.RowIndex].Value;
                DialogResult result = MessageBox.Show("Delete this brand",
                    "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    adapter.DeleteSingleData<Brand>(id, "tblBrands", "brandId");
                    SetupDataTable();
                }
            }
        }
        private void frmBrands_Load(object sender, EventArgs e) {
        }
    }
}
