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
//using Equin.ApplicationFramework;
//using Microsoft.Data.SqlClient;


namespace YourCommunityWorkshop {
    public partial class frmAvailableTools : Form {
        DatabaseManagement.Adapter adapter = new Adapter();
        List<Tools> toolFilterList = new List<Tools>();
        public frmAvailableTools() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTableAvailableTool();
        }
        private void SetupDataTableAvailableTool() {
            toolFilterList = adapter.GetJoinedToolsData(false);
            dgvAvailableTools.DataSource = null;
            dgvAvailableTools.DataSource = toolFilterList;
            dgvAvailableTools.Columns["toolId"].Visible = false;//Hides selected column
            dgvAvailableTools.Columns["statusId"].Visible = false;
            dgvAvailableTools.Columns["brandId"].Visible = false;
            dgvAvailableTools.Columns["productName"].HeaderText = "Tool";
            dgvAvailableTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
            dgvAvailableTools.Columns["statusType"].HeaderText = "Status";
            dgvAvailableTools.Columns["onRental"].HeaderText = "Rental Status";
            dgvAvailableTools.Columns["brandName"].HeaderText = "Brand";
            dgvAvailableTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void frmAvailableTools_Load(object sender, EventArgs e) {
        }
        private void tbxToolName_TextChanged(object sender, EventArgs e) {            
            dgvAvailableTools.DataSource = null;    
            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text, tbxToolBrand.Text);
                dgvAvailableTools.DataSource = dv.ToTable();
                dgvAvailableTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvAvailableTools.Columns["statusId"].Visible = false;
                dgvAvailableTools.Columns["brandId"].Visible = false;
                dgvAvailableTools.Columns["productName"].HeaderText = "Tool";
                dgvAvailableTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvAvailableTools.Columns["statusType"].HeaderText = "Status";
                dgvAvailableTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvAvailableTools.Columns["brandName"].HeaderText = "Brand";
                dgvAvailableTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)
            }
            catch (Exception ex) {

                MessageBox.Show(ex.StackTrace);
            }            
            //var query = toolFilterList.Select(x => x);
            //System.Data.DataTableExtensions.CopyToDataTable
            //DataTable table = query.CopyToDataTable();
            //BindingSource bs = new BindingSource() { DataSource = toolFilterList };
            //dgvAvailableTools.DataSource = bs;
            // var view = (BindingListView<DemoClass>)dataGridView1.DataSource;
            //var view = (BindingListView<Tools>)dgvAvailableTools.DataSource;
            //view.ApplyFilter(item => item.productName=="a" );
            //view.Filter( $"productName = '{ tbxToolName.Text}'");
            //bs.Filter = $"productName = '{ tbxToolName.Text}'";

            //dgvAvailableTools.DataSource = view;
            // dgvAvailableTools.DataSource = toolList;
            //try {
            //    DataTable dt = new DataTable();
            //    dt= dgvAvailableTools.DataSource as DataTable;
            //    dt.DefaultView.RowFilter = string.Format("productName LIKE '%{0}%'", tbxToolName.Text);
            //}
            //catch (Exception ex) {
            //   
            //}
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("productName LIKE '%{0}%'", tbxToolName.Text);
            //dgvAvailableTools.DataSource = dv.ToTable();
        }

        private void btnExport_Click(object sender, EventArgs e) {
            if (dgvAvailableTools.Rows.Count > 0) {
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
                            int columnCount = dgvAvailableTools.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvAvailableTools.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++) {
                                    columnNames += dgvAvailableTools.Columns[i].HeaderText.ToString() + ",";
                                                               
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvAvailableTools.Rows.Count; i++) {
                       
                                for (int j = 0; j < columnCount; j++) {
                                   
                                    if (dgvAvailableTools.Rows[i - 1].Cells[j].Value!=null) {
                                        outputCsv[i] += dgvAvailableTools.Rows[i - 1].Cells[j].Value.ToString() + ",";
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
            dgvAvailableTools.DataSource = null;
            try {
                var Datatable = Adapter.ToDataTable(toolFilterList);
                DataView dv = Datatable.DefaultView;
                dv.RowFilter = string.Format("productName LIKE '%{0}%' AND brandName LIKE '%{1}%' ", tbxToolName.Text, tbxToolBrand.Text);
                dgvAvailableTools.DataSource = dv.ToTable();
                dgvAvailableTools.Columns["toolId"].Visible = false;//Hides selected column
                dgvAvailableTools.Columns["statusId"].Visible = false;
                dgvAvailableTools.Columns["brandId"].Visible = false;
                dgvAvailableTools.Columns["productName"].HeaderText = "Tool";
                dgvAvailableTools.Columns["toolSerialNO"].HeaderText = "Serial Number";
                dgvAvailableTools.Columns["statusType"].HeaderText = "Status";
                dgvAvailableTools.Columns["onRental"].HeaderText = "Rental Status";
                dgvAvailableTools.Columns["brandName"].HeaderText = "Brand";
                dgvAvailableTools.Columns["brandName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)

            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
