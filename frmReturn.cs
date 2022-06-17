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
    public partial class frmReturn : Form {
        Timer tmr = null;
        Rental selectedRental;
        DatabaseManagement.IDataAdapter<Rental> rentalAdapter = new RentalAdapter();
        DatabaseManagement.Adapter adapter = new Adapter();
        Rental rentalDetail;
        Tools selectedTool;
        private void StartTimer() {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        private void tmr_Tick(object sender, EventArgs e) {
            tbxReturnTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public frmReturn(Rental rental) {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            selectedRental = rental;
            SetupLabel();
            SetupTextBox();
            StartTimer();
        }
        private void SetupLabel() {
            lblCustomerName.Text = selectedRental.fullName;
            lblToolName.Text = selectedRental.productName;
        }
        private void SetupTextBox() {
            int id = selectedRental.toolId;
            selectedTool = adapter.GetSingleDataFromTable<Tools>(id, "tblTools", "toolId");
            tbxCondition.Text = selectedTool.condition;
        }
        private void frmReturn_Load(object sender, EventArgs e) {

        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            rentalDetail = selectedRental;
            rentalDetail.dateReturned = System.DateTime.Now;
            rentalAdapter.SaveExistingData(rentalDetail);
            selectedTool.toolId = rentalDetail.toolId;
            selectedTool.onRental = "False";
            selectedTool.condition = tbxCondition.Text;
            adapter.UpdateToolRentalStatus(selectedTool);
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
