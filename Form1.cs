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
            //ResetStatistics();
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

        }


        // --------------------------- Populate the invoice grid view: ---------------------------

        private void populateInvoiceGridView()
        {
            var context = new CustomersBillsContext();
            List<Invoice> invoiceList = new List<Invoice>();
            invoiceList = context.Invoices.ToList<Invoice>();
            invcGrdView.DataSource = null;
            invcGrdView.DataSource = invoiceList;

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
                //    updateStatistics();
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


        // ------------------------------------- Reset method: -------------------------------------

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
                }
            }
            context.Dispose();
        }

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
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selected row index.");
                }
            }


            //var context = new CustomersBillsContext();

            //if (invcGrdView.SelectedCells.Count > 0)
            //{
            //    int selectedRowIndex = invcGrdView.SelectedCells[0].RowIndex;

            //    if (selectedRowIndex >= 0 && selectedRowIndex < invcGrdView.Rows.Count)
            //    {
            //        if (int.TryParse(invcGrdView.Rows[selectedRowIndex].Cells["InvoiceId"].Value?.ToString(), out int invoiceId))
            //        {
            //            Invoice invoiceToDelete = context.Invoices.FirstOrDefault(c => c.InvoiceId == invoiceId);

            //            if (invoiceToDelete != null && MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //            {
            //                context.Invoices.Remove(invoiceToDelete);
            //                context.SaveChanges();
            //                populateInvoiceGridView();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid Invoice ID.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid selected row index.");
            //    }
            //}

            //context.Dispose();
        }

        // -------------------------- Create and add an invoice to the DB: --------------------------
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
                    populateInvoiceGridView();
                }
                else
                {
                    MessageBox.Show("You should select a customer!");
                    return;
                }
              

                // --------------------- Updating statistics and reseting the form: ---------------------

                //updateStatistics();
                ResetFields();
            }
        }
    }
}
