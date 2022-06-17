using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagement;

namespace YourCommunityWorkshop {
    public partial class frmUnavailableTools : Form {
        DatabaseManagement.Adapter adapter = new Adapter();
        List<Tools> toolFilterList = new List<Tools>();
        public frmUnavailableTools() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTableUnavailableTool();
        }
        private void SetupDataTableUnavailableTool() {
            toolFilterList = adapter.GetJoinedToolsData(true);
            dgvUnavailableTools.DataSource = null;
            dgvUnavailableTools.DataSource = toolFilterList;
            dgvUnavailableTools.Columns["toolId"].Visible = false;//Hides selected column
            dgvUnavailableTools.Columns["statusId"].Visible = false;
            dgvUnavailableTools.Columns["brandId"].Visible = false;
            dgvUnavailableTools.Columns["productName"].HeaderText = "Tool";
            dgvUnavailableTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
            dgvUnavailableTools.Columns["statusType"].HeaderText = "Status";
            dgvUnavailableTools.Columns["onRental"].HeaderText = "Rental Status";
            dgvUnavailableTools.Columns["brandName"].HeaderText = "Brand";
            dgvUnavailableTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        }
        private void frmUnavailableTools_Load(object sender, EventArgs e) {

        }

        private void tbxToolName_TextChanged(object sender, EventArgs e) {
            dgvUnavailableTools.DataSource = null;              
            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text, tbxToolBrand.Text);
                dgvUnavailableTools.DataSource = dv.ToTable();
                dgvUnavailableTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvUnavailableTools.Columns["statusId"].Visible = false;
                dgvUnavailableTools.Columns["brandId"].Visible = false;
                dgvUnavailableTools.Columns["productName"].HeaderText = "Tool";
                dgvUnavailableTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvUnavailableTools.Columns["statusType"].HeaderText = "Status";
                dgvUnavailableTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvUnavailableTools.Columns["brandName"].HeaderText = "Brand";
                dgvUnavailableTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            if (dgvUnavailableTools.Rows.Count > 0) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK) {
                    if (File.Exists(sfd.FileName)) {
                        try {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex) {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError) {
                        try {
                            int columnCount = dgvUnavailableTools.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvUnavailableTools.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++) {
                                columnNames += dgvUnavailableTools.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;
                            for (int i = 1; (i - 1) < dgvUnavailableTools.Rows.Count; i++) {
                                for (int j = 0; j < columnCount; j++) {
                                    if (dgvUnavailableTools.Rows[i - 1].Cells[j].Value != null) {
                                        outputCsv[i] += dgvUnavailableTools.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex) {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        private void tbxToolBrand_TextChanged(object sender, EventArgs e) {
            dgvUnavailableTools.DataSource = null; 
            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text, tbxToolBrand.Text);
                dgvUnavailableTools.DataSource = dv.ToTable();
                dgvUnavailableTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvUnavailableTools.Columns["statusId"].Visible = false;
                dgvUnavailableTools.Columns["brandId"].Visible = false;
                dgvUnavailableTools.Columns["productName"].HeaderText = "Tool";
                dgvUnavailableTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvUnavailableTools.Columns["statusType"].HeaderText = "Status";
                dgvUnavailableTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvUnavailableTools.Columns["brandName"].HeaderText = "Brand";
                dgvUnavailableTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }    
}
