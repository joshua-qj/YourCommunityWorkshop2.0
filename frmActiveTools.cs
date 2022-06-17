using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DatabaseManagement;

namespace YourCommunityWorkshop {
    public partial class frmActiveTools : Form {
        DatabaseManagement.Adapter adapter = new Adapter(); 
        List<Tools> toolFilterList = new List<Tools>();
        public frmActiveTools() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTableRetiredTool();
        }
        private void SetupDataTableRetiredTool() {
            toolFilterList = adapter.GetJoinedToolsData(1);
            dgvActiveTools.DataSource = null;
            dgvActiveTools.DataSource = toolFilterList;
            dgvActiveTools.Columns["toolId"].Visible = false;//Hides selected column
            dgvActiveTools.Columns["statusId"].Visible = false;
            dgvActiveTools.Columns["brandId"].Visible = false;
            dgvActiveTools.Columns["productName"].HeaderText = "Tool";
            dgvActiveTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
            dgvActiveTools.Columns["statusType"].HeaderText = "Status";
            dgvActiveTools.Columns["onRental"].HeaderText = "Rental Status";
            dgvActiveTools.Columns["brandName"].HeaderText = "Brand";
            dgvActiveTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        }

        private void tbxToolName_TextChanged(object sender, EventArgs e) {
            dgvActiveTools.DataSource = null;
            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text,tbxToolBrand.Text);
                dgvActiveTools.DataSource = dv.ToTable();
                dgvActiveTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvActiveTools.Columns["statusId"].Visible = false;
                dgvActiveTools.Columns["brandId"].Visible = false;
                dgvActiveTools.Columns["productName"].HeaderText = "Tool";
                dgvActiveTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvActiveTools.Columns["statusType"].HeaderText = "Status";
                dgvActiveTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvActiveTools.Columns["brandName"].HeaderText = "Brand";
                dgvActiveTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)

            }
            catch (Exception ex) {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void tbxToolBrand_TextChanged(object sender, EventArgs e) {
            dgvActiveTools.DataSource = null;

            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text, tbxToolBrand.Text);
                dgvActiveTools.DataSource = dv.ToTable();
                dgvActiveTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvActiveTools.Columns["statusId"].Visible = false;
                dgvActiveTools.Columns["brandId"].Visible = false;
                dgvActiveTools.Columns["productName"].HeaderText = "Tool";
                dgvActiveTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvActiveTools.Columns["statusType"].HeaderText = "Status";
                dgvActiveTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvActiveTools.Columns["brandName"].HeaderText = "Brand";
                dgvActiveTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)

            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnExport_Click(object sender, EventArgs e) {
            if (dgvActiveTools.Rows.Count > 0) {
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
                            int columnCount = dgvActiveTools.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvActiveTools.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++) {
                                columnNames += dgvActiveTools.Columns[i].HeaderText.ToString() + ",";

                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvActiveTools.Rows.Count; i++) {

                                for (int j = 0; j < columnCount; j++) {
                                
                                    if (dgvActiveTools.Rows[i - 1].Cells[j].Value != null) {
                                        outputCsv[i] += dgvActiveTools.Rows[i - 1].Cells[j].Value.ToString() + ",";

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
    }
    
}
