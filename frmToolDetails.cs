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
    public partial class frmToolDetails : Form {
        List<Brand> brandList = new List<Brand>();
        List<Status> StatusList = new List<Status>();
        Tools tool = new Tools();       
        bool isNew = true;
        DatabaseManagement.IDataAdapter<Tools> toolAdapter = new ToolAdapter();
        DatabaseManagement.Adapter adapter = new Adapter();
        public frmToolDetails() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            PoplulateBrandCbo();
            PoplulateStatusCbo();
        }
        public frmToolDetails(int id) {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            isNew = false;
            ShowCustomerDetails(id);
        }
        private void ShowCustomerDetails(int id) {
            brandList = adapter.GetAllDataFromTable<Brand>("tblBrands");
            cboBrand.DataSource = brandList;
            cboBrand.ValueMember = "BrandId";
            cboBrand.DisplayMember = "brandName";

            StatusList = adapter.GetAllDataFromTable<Status>("tblStatus");
            cboStatus.DataSource = StatusList;
            cboStatus.ValueMember = "StatusId";
            cboStatus.DisplayMember = "statusType";
            tool = adapter.GetSingleDataFromTable<Tools>(id, "tblTools", "toolId");
            tbxToolName.Text = tool.productName;
            tbxSerialNO.Text = tool.toolSerialNO;
            cboBrand.SelectedValue = tool.brandId;
            cboStatus.SelectedValue = tool.statusId;
            tbxCondition.Text = tool.condition;
           // cboStatus.Text =cboStatus.Items[tool.statusId].ToString();
        }
        private void PoplulateBrandCbo() {
            brandList = adapter.GetAllDataFromTable<Brand>("tblBrands");
            cboBrand.DataSource = brandList;
            cboBrand.ValueMember = "BrandId";
            cboBrand.DisplayMember = "brandName";
            cboBrand.SelectedIndex = -1;
        }
        private void PoplulateStatusCbo() {
            StatusList = adapter.GetAllDataFromTable<Status>("tblStatus");
            cboStatus.DataSource = StatusList;
            cboStatus.ValueMember = "StatusId";
            cboStatus.DisplayMember = "statusType";
            cboStatus.SelectedIndex = -1;
        }
        private void frmToolDetails_Load(object sender, EventArgs e) {

        }
        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void btnSave_Click(object sender, EventArgs e) {

            SaveNewTool();
        }
        private bool AreTextFieldsCompleted() {         
            if (String.IsNullOrWhiteSpace(tbxToolName.Text)) {
                return false;
            }
            if (!(cboBrand.SelectedIndex > -1)) {
                return false;
            }
            if (!(cboStatus.SelectedIndex > -1)) {
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbxCondition.Text)) {
                return false;
            }
            return true;
        }
        private void SaveNewTool() {
            if (AreTextFieldsCompleted()) {
                tool.productName = tbxToolName.Text;
                tool.toolSerialNO = tbxSerialNO.Text;
                tool.brandId = (int)cboBrand.SelectedValue;
                tool.statusId = (int)cboStatus.SelectedValue;
                tool.onRental = "False";
               
                if (!String.IsNullOrWhiteSpace(tbxCondition.Text)) {
                    tool.condition = tbxCondition.Text;
                } 

                if (isNew) {
                    toolAdapter.AddNewData(tool);
                }
                else {
                    toolAdapter.SaveExistingData(tool);
                }
                this.DialogResult = DialogResult.OK;
                return;
            }
            else
            MessageBox.Show("PLEASE COMPLETE ALL FIELDS BEFORE SAVING");
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
