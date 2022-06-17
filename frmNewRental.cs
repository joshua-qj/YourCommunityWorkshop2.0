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
    public partial class frmNewRental : Form {
        Timer tmr = null;
        DatabaseManagement.IDataAdapter<Rental> rentalAdapter = new RentalAdapter();
        DatabaseManagement.Adapter adapter = new Adapter();
        List<Customer> customerList = new List<Customer>();
        List<Tools> toolList = new List<Tools>();
        public frmNewRental() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            StartTimer();
            PoplulateCustomerCbo();
            PoplulateToolCbo();
        }
        private void StartTimer() {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }
        private void tmr_Tick(object sender, EventArgs e) {
            tbxRentalTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void PoplulateCustomerCbo() {
            customerList = adapter.GetAllDataFromTable<Customer>("tblCustomers");
            cboCustomer.DataSource = customerList;
            cboCustomer.ValueMember = "customerId";
            cboCustomer.DisplayMember = "fullName";
            cboCustomer.SelectedIndex = -1;
        }
        private void PoplulateToolCbo() {            
            toolList = adapter.GetAllDataFromTable<Tools>("tblTools");
            cboTool.DataSource = toolList.Where(item =>  {
                return item.statusId != 2 && item.onRental == "False"; // 2 is stand for retired status
            }).OrderByDescending(item=>item.toolId).ToList();          
            cboTool.ValueMember = "toolId";
            cboTool.DisplayMember = "productName";         
            cboTool.SelectedIndex = -1;
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void frmNewRental_Load(object sender, EventArgs e) {

        }
        private void btnSave_Click(object sender, EventArgs e) {
            if (cboCustomer.SelectedIndex > -1 && cboTool.SelectedIndex > -1) {
                Rental newRental = new Rental();
                newRental.customerId = (int)cboCustomer.SelectedValue;
                newRental.toolId = (int)cboTool.SelectedValue;
                newRental.dateRented = System.DateTime.Now;
                rentalAdapter.AddNewData(newRental);
                //Update using tool object
                Tools updatedTool = new Tools();
                updatedTool.condition = tbxToolCondition.Text;
                updatedTool.toolId = (int)cboTool.SelectedValue;
                updatedTool.onRental = "true";
                  adapter.UpdateToolRentalStatus(updatedTool);         
                this.DialogResult = DialogResult.OK;
                return;
            }
            else
            MessageBox.Show("PLEASE COMPLETE ALL FIELDS BEFORE SAVING");
        }
        private void cboTool_SelectedIndexChanged(object sender, EventArgs e) {
            //this.cboTool.SelectedIndexChanged += new System.EventHandler(this.cboTool_SelectedIndexChanged) is subscribtion
            //cboTool is event source, tbxToolCondition is event subscriber, 
            //System.EventHandler(this.cboTool_SelectedIndexChanged) is EventHandler
            //cboTool_SelectedIndexChanged is event
            Tools selectedTool = new Tools();           
            if (cboTool.SelectedIndex >-1) {                
                selectedTool = toolList.Single(item => item.toolId == (int)cboTool.SelectedValue);                
                tbxToolCondition.Text = selectedTool.condition;
            }           
        }
    }
}
