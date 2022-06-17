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
    public partial class frmCustomerDetails : Form {
        Customer customer = new Customer();
        DatabaseManagement.IDataAdapter<Customer> dataAdapter = new CustomerAdapter();
        DatabaseManagement.Adapter adapter = new Adapter();
        bool isNew = true;
        public frmCustomerDetails() {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
        }
        public frmCustomerDetails(int id) {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Setting;
            isNew = false;
            ShowCustomerDetails(id);
        }
        private void ShowCustomerDetails(int id) {
            customer = adapter.GetSingleDataFromTable<Customer>(id,"tblCustomers","customerId");
            tbxFirstName.Text = customer.firstName;
            tbxLastName.Text = customer.lastName;
            tbxPhoneNumber.Text = customer.phoneNumber;
            tbxEmail.Text = customer.email;
        }
        private void SaveNewCustomer() {
            if (AreTextFieldsCompleted()) {
                customer.firstName = tbxFirstName.Text;
                customer.lastName = tbxLastName.Text;
                customer.phoneNumber = tbxPhoneNumber.Text;
                customer.email = tbxEmail.Text;

                if (isNew) {
                    dataAdapter.AddNewData(customer);
                }
                else {
                    dataAdapter.SaveExistingData(customer);
                }
              DialogResult = DialogResult.OK;
            }
            else
            MessageBox.Show("PLEASE COMPLETE ALL FIELDS BEFORE SAVING");
        }
        private bool AreTextFieldsCompleted() {
            if (String.IsNullOrWhiteSpace(tbxFirstName.Text)) {
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbxLastName.Text)) {
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbxPhoneNumber.Text)) {
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbxEmail.Text)) {
                return false;
            }
            return true;
        }
        private void frmCustomerDetails_Load(object sender, EventArgs e) {

        }
        private void btnSave_Click(object sender, EventArgs e) {
            SaveNewCustomer();
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
