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
using System.IO;
using System.Data;

namespace YourCommunityWorkshop {
    public partial class frmRetiredTools : Form {
        DatabaseManagement.Adapter adapter = new Adapter();
        List<Tools> toolFilterList = new List<Tools>();
        public frmRetiredTools() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTableRetiredTool();
        }
        private void SetupDataTableRetiredTool() {
            toolFilterList = adapter.GetJoinedToolsData(2);
            dgvRetiredTools.DataSource = null;
            dgvRetiredTools.DataSource = toolFilterList;
            dgvRetiredTools.Columns["toolId"].Visible = false;//Hides selected column
            dgvRetiredTools.Columns["statusId"].Visible = false;
            dgvRetiredTools.Columns["brandId"].Visible = false;
            dgvRetiredTools.Columns["productName"].HeaderText = "Tool";
            dgvRetiredTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
            dgvRetiredTools.Columns["statusType"].HeaderText = "Status";
            dgvRetiredTools.Columns["onRental"].HeaderText = "Rental Status";
            dgvRetiredTools.Columns["brandName"].HeaderText = "Brand";
            dgvRetiredTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        }
        private void frmRetiredTools_Load(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void tbxToolName_TextChanged(object sender, EventArgs e) {
            dgvRetiredTools.DataSource = null;
            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text, tbxToolBrand.Text);
                dgvRetiredTools.DataSource = dv.ToTable();
                dgvRetiredTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvRetiredTools.Columns["statusId"].Visible = false;
                dgvRetiredTools.Columns["brandId"].Visible = false;
                dgvRetiredTools.Columns["productName"].HeaderText = "Tool";
                dgvRetiredTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvRetiredTools.Columns["statusType"].HeaderText = "Status";
                dgvRetiredTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvRetiredTools.Columns["brandName"].HeaderText = "Brand";
                dgvRetiredTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)

            }
            catch (Exception ex) {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            if (dgvRetiredTools.Rows.Count > 0) {
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
                            int columnCount = dgvRetiredTools.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvRetiredTools.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++) {
                                columnNames += dgvRetiredTools.Columns[i].HeaderText.ToString() + ",";

                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvRetiredTools.Rows.Count; i++) {

                                for (int j = 0; j < columnCount; j++) {
                                      if (dgvRetiredTools.Rows[i - 1].Cells[j].Value != null) {
                                        outputCsv[i] += dgvRetiredTools.Rows[i - 1].Cells[j].Value.ToString() + ",";

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
            dgvRetiredTools.DataSource = null;
            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text, tbxToolBrand.Text);
                dgvRetiredTools.DataSource = dv.ToTable();
                dgvRetiredTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvRetiredTools.Columns["statusId"].Visible = false;
                dgvRetiredTools.Columns["brandId"].Visible = false;
                dgvRetiredTools.Columns["productName"].HeaderText = "Tool";
                dgvRetiredTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvRetiredTools.Columns["statusType"].HeaderText = "Status";
                dgvRetiredTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvRetiredTools.Columns["brandName"].HeaderText = "Brand";
                dgvRetiredTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
