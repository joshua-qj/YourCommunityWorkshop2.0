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
    public partial class frmRental : Form {
        List<Rental> rentalList = new List<Rental>();
        DatabaseManagement.Adapter adapter = new Adapter();

        public frmRental() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            SetupDataTable();
        }
        private void SetupDataTable() {
            rentalList = adapter.GetJoinedRentalData();
            dgvRental.DataSource = null;
            dgvRental.DataSource = rentalList;
            dgvRental.Columns["rentalId"].Visible = false;
            dgvRental.Columns["toolId"].Visible = false;
            dgvRental.Columns["customerId"].Visible = false;
            dgvRental.Columns["firstName"].Visible = false;
            dgvRental.Columns["lastName"].Visible = false;
            dgvRental.Columns["fullName"].HeaderText = "Customer";
            dgvRental.Columns["productName"].HeaderText = "Tool";
            dgvRental.Columns["dateRented"].HeaderText = "Rent time";
            dgvRental.Columns["dateReturned"].HeaderText = "Return time";
        }
        private void btnNew_Click(object sender, EventArgs e) {
            var frm = new frmNewRental();
            if (frm.ShowDialog() == DialogResult.OK) {
                SetupDataTable();
            }
        }

        private void frmRental_Load(object sender, EventArgs e) {

        }
        private void dgvRental_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e) {
            if (dgvRental.Rows.Count > 0) {
                int id = dgvRental.CurrentCell.RowIndex;
                Rental loan = rentalList[id];
                if (loan.dateReturned == null) {
                    var frm = new frmReturn(loan);
                    if (frm.ShowDialog() == DialogResult.OK) {
                        SetupDataTable();
                    }
                    return;
                }
                else
                    MessageBox.Show("This item has already been returned!");
            }
        }
        private void dgvRental_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvRental.Rows.Count > 0) {
                int id = (int)dgvRental["rentalId", dgvRental.CurrentCell.RowIndex].Value;
                DialogResult result = MessageBox.Show("Delete this rental record",
                    "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    adapter.DeleteSingleData<Rental>(id, "tblRentals", "rentalId");
                    SetupDataTable();
                }

            }
        }
    }
}
