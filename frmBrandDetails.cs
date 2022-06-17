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
    public partial class frmBrandDetails : Form {
        Brand brand = new Brand();
        DatabaseManagement.IDataAdapter<Brand> brandAdapter = new BrandAdapter();
        DatabaseManagement.Adapter adapter = new Adapter();
        bool isNew = true;
        public frmBrandDetails() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
        }
        public frmBrandDetails(int id) {
            InitializeComponent(); 
            this.BackColor = Properties.Settings.Default.Setting;
            isNew = false;
            ShowBrandDetails(id);
        }
        #region button event
        #endregion

        #region setupMethod



        #endregion

        #region interaction Method
        #endregion


        private void ShowBrandDetails(int id) {
            brand = adapter.GetSingleDataFromTable<Brand>(id, "tblBrands", "brandId");
            tbxBrandName.Text = brand.brandName;
        }

        private void SaveNewbrand() {

            if (AreTextFieldsCompleted()) {
                brand.brandName = tbxBrandName.Text;
                if (isNew) {
                    brandAdapter.AddNewData(brand);
                }
                else {
                    brandAdapter.SaveExistingData(brand);
                }
                this.DialogResult = DialogResult.OK;
            }  
            else
            MessageBox.Show("PLEASE COMPLETE ALL FIELDS BEFORE SAVING");
        }


        private bool AreTextFieldsCompleted() {
            if (String.IsNullOrWhiteSpace(tbxBrandName.Text)) {
                return false;
            }    
            return true;
        }
        private void frmBrandDetails_Load(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveNewbrand();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
