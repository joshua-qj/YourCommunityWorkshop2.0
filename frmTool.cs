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
    public partial class frmTool : Form {
        List<Tools> toolList = new List<Tools>();
        DatabaseManagement.Adapter adapter = new Adapter();
        public frmTool() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTable();
        }

        private void SetupDataTable() {
            toolList = adapter.GetJoinedToolsData();
            dgvTool.DataSource = null;
            dgvTool.DataSource = toolList;
            dgvTool.Columns["toolId"].Visible = false;//Hides selected column
            dgvTool.Columns["statusId"].Visible = false;
            dgvTool.Columns["brandId"].Visible = false;
            dgvTool.Columns["productName"].HeaderText = "Tool";
            dgvTool.Columns["toolSerialNO"].HeaderText = "Serial Number";
            dgvTool.Columns["statusType"].HeaderText = "Status";
            dgvTool.Columns["onRental"].HeaderText = "Rental Status";
            dgvTool.Columns["brandName"].HeaderText = "Brand";
            dgvTool.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        }

        //private void SetupDataTable(string toolName) {
        //    toolList = adapter.GetJoinedToolsData();
        //    dgvTool.DataSource = null;
        //    dgvTool.DataSource = toolList;
        //    dgvTool.Columns["toolId"].Visible = false;//Hides selected column
        //    dgvTool.Columns["statusId"].Visible = false;
        //    dgvTool.Columns["brandId"].Visible = false;
        //    dgvTool.Columns["productName"].HeaderText = "Tool";
        //    dgvTool.Columns["toolSerialNO"].HeaderText = "Serial Number";
        //    dgvTool.Columns["statusType"].HeaderText = "Status";
        //    dgvTool.Columns["onRental"].HeaderText = "Rental Status";
        //    dgvTool.Columns["brandName"].HeaderText = "Brand";
        //    dgvTool.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        //}
        private void SetupDataTable(string toolBrand, string toolName) {
            toolList = adapter.GetJoinedToolsData();
            dgvTool.DataSource = null;
            dgvTool.DataSource = toolList;
            dgvTool.Columns["toolId"].Visible = false;//Hides selected column
            dgvTool.Columns["statusId"].Visible = false;
            dgvTool.Columns["brandId"].Visible = false;
            dgvTool.Columns["productName"].HeaderText = "Tool";
            dgvTool.Columns["toolSerialNO"].HeaderText = "Serial Number";
            dgvTool.Columns["statusType"].HeaderText = "Status";
            dgvTool.Columns["onRental"].HeaderText = "Rental Status";
            dgvTool.Columns["brandName"].HeaderText = "Brand";
            dgvTool.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        }
        private void btnDelete_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var frm = new frmToolDetails();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }
        private void frmTool_Load(object sender, EventArgs e) {

        }

        private void dgvTool_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int id = (int)dgvTool["toolId", dgvTool.CurrentCell.RowIndex].Value;
            frmToolDetails frm = new frmToolDetails(id);
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e) {
            if (dgvTool.Rows.Count > 0) {
                int id = (int)dgvTool["toolId", dgvTool.CurrentCell.RowIndex].Value;
                DialogResult result = MessageBox.Show("Delete this tool?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    adapter.DeleteSingleData<Tools>(id, "tblTools", "toolId");
                    SetupDataTable();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }



        private void btnAvailableTools_Click(object sender, EventArgs e) {

       
            var frm = new frmAvailableTools();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }        
        }

        private void btnUnavailableTools_Click(object sender, EventArgs e) {
            var frm = new frmUnavailableTools();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }

        private void btnRetiredTools_Click(object sender, EventArgs e) {
            var frm = new frmRetiredTools();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }

        private void btnActiveTools_Click(object sender, EventArgs e) {
            var frm = new frmActiveTools();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }
    }
}
