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
    public partial class frmCustomer : Form {
        List<Customer> customerList = new List<Customer>();
        DatabaseManagement.IDataAdapter<Customer> customerAdapter = new CustomerAdapter();
        DatabaseManagement.Adapter adapter = new Adapter();
        public frmCustomer() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTable();
        }
        private void SetupDataTable() {
            customerList = adapter.GetAllDataFromTable<Customer>("tblCustomers");
            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = customerList;
            dgvCustomer.Columns["customerId"].Visible = false;//Hides selected column
            dgvCustomer.Columns["fullName"].Visible = false;
            dgvCustomer.Columns["firstName"].HeaderText = "First Name";
            dgvCustomer.Columns["lastName"].HeaderText = "Surname";
            dgvCustomer.Columns["phoneNumber"].HeaderText = "Phone Number";
            dgvCustomer.Columns["email"].HeaderText = "E-mail";
            dgvCustomer.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Allots excess column spacing to this column (Shared)

        }
        private void frmCustomer_Load(object sender, EventArgs e) {

        }

        private void btnNew_Click(object sender, EventArgs e) {
            frmCustomerDetails frm = new frmCustomerDetails();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvCustomer.Rows.Count > 0) {
                int id = (int)dgvCustomer["customerId", dgvCustomer.CurrentCell.RowIndex].Value;
                DialogResult result = MessageBox.Show("Delete this person",
                    "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    adapter.DeleteSingleData<Customer>(id, "tblCustomers", "customerId");
                    SetupDataTable();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e) {
            int id = (int)dgvCustomer["customerId", dgvCustomer.CurrentCell.RowIndex].Value;
            frmCustomerDetails frm = new frmCustomerDetails(id);
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }
    }
}
