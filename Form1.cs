using Lab_3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab_3
{
    public partial class Form1 : Form
    {
        // ------------------------------------- Variables: -------------------------------------

        List<Customer> customerList;


        // ------------------------------- Initializing the form: -------------------------------

        public Form1()
        {
            InitializeComponent();
            populateCustomerGridView();
            populateInvoiceGridView();
            updateStatistics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        // --------------------------- Populate the cutomer grid view: ---------------------------

        private void populateCustomerGridView()
        {
            var context = new CustomersBillsContext();
            List<Customer> customersList = new List<Customer>();
            customerList = context.Customers.ToList<Customer>();
            cstGrdView.DataSource = null;
            cstGrdView.DataSource = customerList;
            cstGrdView.Columns["Invoices"].Visible = false;

        }


        // --------------------------- Populate the invoice grid view: ---------------------------

        private void populateInvoiceGridView()
        {
            var context = new CustomersBillsContext();
            List<Invoice> invoiceList = new List<Invoice>();
            invoiceList = context.Invoices.ToList<Invoice>();
            invcGrdView.DataSource = null;
            invcGrdView.DataSource = invoiceList;
            invcGrdView.Columns["AccountNumberNavigation"].Visible = false;

        }


        // ------------------------- Create and add a cutomer to the DB: -------------------------

        private void btnAddCstmr_Click(object sender, EventArgs e)
        {
            string accountNo = txtBxAccNmbr.Text;
            string fName = txtBxFrstNm.Text;
            string lName = txtBxLstNm.Text;

            if (fName == "" || lName == "")
            {
                MessageBox.Show("You have to enter First Name, Last Name!");
            }
            else
            {
                // --------------- Creating a new customer based on the filled textboxes: ---------------
                Customer currentCustomer;

                if (accountNo == "")
                {
                    currentCustomer = new Customer(fName, lName);

                }
                else
                {
                    int accNo = Convert.ToInt32(accountNo);
                    bool isIdUnique = checkUniqueness(accNo);
                    if (isIdUnique)
                    {
                        currentCustomer = new Customer(accNo, fName, lName);
                    }

                    else
                    {
                        MessageBox.Show("The account number you entered is already used for a customer!");
                        return;
                    }
                }

                // ----------------------- Showing the new customer in a Messagebox: -----------------------

                MessageBox.Show(currentCustomer.ToString());

                // -------------------------- Adding the new customer into theDB: --------------------------

                var context = new CustomersBillsContext();
                context.Customers.Add(currentCustomer);
                context.SaveChanges();
                context.Dispose();

                // ----------------- Updating statistics, gridView and reseting the form: -----------------

                populateCustomerGridView();
                updateStatistics();
                ResetFields();
            }
        }


        // ------------------- Check if the provided account number is unique: -------------------

        private bool checkUniqueness(int number)
        {
            var context = new CustomersBillsContext();
            var customer = context.Customers
                .Where(c => c.AccountNumber == number)
                .Select(c => new { c.AccountNumber })
                .FirstOrDefault(); ;
            if (customer != null)
                return false;
            else return true;
        }


        // ------------------------------------ Reset method: ------------------------------------

        private void ResetFields()
        {
            txtBxAccNmbr.Text = "";
            txtBxFrstNm.Text = "";
            txtBxLstNm.Text = "";
            txtPwrUsg.Text = "";
            txtBxAccNmbr.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // --------------------------- Remove a customer from the DB: ----------------------------

        private void rmvCstmr_Click(object sender, EventArgs e)
        {
            var context = new CustomersBillsContext();
            int selectedRowIndex = cstGrdView.SelectedCells[0].RowIndex;
            int accountNumber = Convert.ToInt32(cstGrdView.Rows[selectedRowIndex].Cells["AccountNumber"].Value);
            Customer customerToDelete = context.Customers.FirstOrDefault(c => c.AccountNumber == accountNumber);
            if (customerToDelete != null)
            {
                if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Customers.Remove(customerToDelete);
                    context.SaveChanges();
                    populateCustomerGridView();
                    populateInvoiceGridView();
                    updateStatistics();
                }
            }
            context.Dispose();
        }


        // --------------------------- Remove an invoice from the list: --------------------------

        private void rmvInvc_Click(object sender, EventArgs e)
        {
            if (invcGrdView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = invcGrdView.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {
                    int invoiceId = Convert.ToInt32(invcGrdView.Rows[selectedRowIndex].Cells["InvoiceId"].Value);
                    var context = new CustomersBillsContext();
                    Invoice invoiceToDelete = context.Invoices.FirstOrDefault(c => c.InvoiceId == invoiceId);

                    if (invoiceToDelete != null)
                    {
                        if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            context.Invoices.Remove(invoiceToDelete);
                            context.SaveChanges();
                            context.Dispose();
                            populateInvoiceGridView();
                            updateStatistics();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selected row index.");
                }
            }
        }


        // ------------------------- Create and add an invoice to the DB: ------------------------

        private void btnAddInvc_Click(object sender, EventArgs e)
        {
            DateTime invDateTime = invDatePkr.Value;
            string pwUsg = txtPwrUsg.Text;

            if (pwUsg == "")
            {
                MessageBox.Show("You have to enter Power Usage!");
            }
            else
            {
                DateOnly invDate = new DateOnly(invDateTime.Year, invDateTime.Month, invDateTime.Day);

                // --------------- Getting power usage amount and round it in the textbox: ---------------

                decimal powerUsg = Math.Round(Convert.ToDecimal(pwUsg), 2);

                txtPwrUsg.Text = powerUsg.ToString();

                // --------------- Creating a new Invoice based on the filled textboxes: ---------------

                int selectedRowIndex = cstGrdView.SelectedCells[0].RowIndex;
                int accountNumber = Convert.ToInt32(cstGrdView.Rows[selectedRowIndex].Cells["AccountNumber"].Value);
                if (accountNumber != 0)
                {
                    Invoice currentInvoice = new Invoice(accountNumber, powerUsg, invDate);
                    var context = new CustomersBillsContext();
                    context.Invoices.Add(currentInvoice);
                    context.SaveChanges();
                    context.Dispose();
                    currentInvoice.ToString();
                    populateInvoiceGridView();
                    updateStatistics();
                }
                else
                {
                    MessageBox.Show("You should select a customer!");
                    return;
                }


                // --------------------- Updating statistics and reseting the form: ---------------------

                updateStatistics();
                ResetFields();
            }
        }


        // --------------- Check if the provided account number is positive integer: ---------------

        private void txtBxAccNmbr_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBxAccNmbr.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBxAccNmbr.Text = txtBxAccNmbr.Text.Remove(txtBxAccNmbr.Text.Length - 1);
            }
        }


        // ---------------- Check if the provided power usage is positive decimal: ----------------

        private void txtPwrUsg_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPwrUsg.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPwrUsg.Text = txtPwrUsg.Text.Remove(txtPwrUsg.Text.Length - 1);
            }
        }


        // ------------------------------- Update customer: -------------------------------

        private void updtCstmr_Click(object sender, EventArgs e)
        {
            txtBxAccNmbr.Enabled = false;
            string fName = txtBxFrstNm.Text;
            string lName = txtBxLstNm.Text;

            var context = new CustomersBillsContext();
            int selectedRowIndex = cstGrdView.SelectedCells[0].RowIndex;
            int accountNumber = Convert.ToInt32(cstGrdView.Rows[selectedRowIndex].Cells["AccountNumber"].Value);
            Customer customerToupdate = context.Customers.FirstOrDefault(c => c.AccountNumber == accountNumber);

            if (fName == "" || lName == "")
            {
                MessageBox.Show("You have to enter First Name and Last Name!");
            }
            else
            {
                // ----------------- Finding the customer based on the filled textboxes: -----------------

                if (customerToupdate != null)
                {
                    if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // ----------------- Update the properties of the existing customer: -----------------
                        customerToupdate.FirstName = fName;
                        customerToupdate.LastName = lName;
                        context.SaveChanges();
                        populateCustomerGridView();
                        updateStatistics();
                        ResetFields();
                    }
                }
            }
            txtBxAccNmbr.Enabled = true;
            context.Dispose();
        }


        // ------------------------------- Update invoice: -------------------------------

        private void updtInvc_Click(object sender, EventArgs e)
        {
            DateTime invDateTime = invDatePkr.Value;
            string pwUsg = txtPwrUsg.Text;

            if (pwUsg == "")
            {
                MessageBox.Show("You have to enter Power Usage!");
            }
            else
            {
                DateOnly invDate = new DateOnly(invDateTime.Year, invDateTime.Month, invDateTime.Day);

                // --------------- Getting power usage amount and round it in the textbox: ---------------

                decimal powerUsg = Math.Round(Convert.ToDecimal(pwUsg), 2);

                txtPwrUsg.Text = powerUsg.ToString();

                // --------------- Updating the Invoice based on the filled textboxes: ---------------

                if (invcGrdView.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = invcGrdView.SelectedCells[0].RowIndex;

                    if (selectedRowIndex >= 0)
                    {
                        int invoiceId = Convert.ToInt32(invcGrdView.Rows[selectedRowIndex].Cells["InvoiceId"].Value);
                        var context = new CustomersBillsContext();
                        Invoice invoiceToUpdate = context.Invoices.FirstOrDefault(c => c.InvoiceId == invoiceId);

                        if (invoiceToUpdate != null)
                        {
                            if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {

                                invoiceToUpdate.UpdateInvoice(powerUsg, invDate);
                                
                                context.SaveChanges();
                                context.Dispose();
                                populateInvoiceGridView();
                                updateStatistics();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid selected row index.");
                    }
                }
                ResetFields();
            }
        }


        // ------------------------------- Update statistics method: -------------------------------

        private void updateStatistics()
        {
            int noOfCustomers = cstGrdView.RowCount;
            txtbNoCstm.Text = noOfCustomers.ToString();

            decimal totalUsage = 0;
            decimal totalBillAmount = 0;

            foreach (DataGridViewRow row in invcGrdView.Rows)
            {
                DataGridViewCell pwUsCell = row.Cells["PowerUsage"];
                decimal cellPwrUsg = Convert.ToDecimal(pwUsCell.Value);
                totalUsage += cellPwrUsg;

                DataGridViewCell invcCell = row.Cells["InvoiceTotal"];
                decimal cellInv = Convert.ToDecimal(invcCell.Value);
                totalBillAmount += cellInv;
            }

            txtbTtlUsg.Text = totalUsage.ToString();
            if (noOfCustomers > 0)
                txtbAvgBill.Text = (totalBillAmount / noOfCustomers).ToString("C");
            else
                txtbAvgBill.Text = 0.ToString("C");
        }
    }
}
