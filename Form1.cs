using Lab_3.Models;


namespace Lab_3
{
    public partial class Form1 : Form
    {
        // ------------------------------------- Variables: -------------------------------------

        List<Customer> customerList;
        Customer currentCustomer;


        // ------------------------------- Initializing the form: -------------------------------

        public Form1()
        {
            InitializeComponent();

            //ResetStatistics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        // ------------------------ Create and add a cutomer to the list: ------------------------

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
                currentCustomer = new Customer();

                if (accountNo == "")
                {
                    currentCustomer.FirstName = fName; 
                    currentCustomer.LastName = lName;

                }
                    

                else
                {
                    int accNo = Convert.ToInt32(accountNo);
                    bool isIdUnique = checkUniqueness(accNo);
                    if (isIdUnique)
                    {
                        currentCustomer.AccountNumber = accNo;
                        currentCustomer.FirstName = fName;
                        currentCustomer.LastName = lName;
                    }

                    else
                    {
                        MessageBox.Show("The account number you entered is already used for a customer!");
                        return;
                    }
                }

                // ----------------------- Showing the new customer in a Showbox: -----------------------

                MessageBox.Show(currentCustomer.ToString());

                // ----------------- Adding the new customer into the listbox and list: -----------------

                var context = new CustomersBillsContext();
                context.Customers.Add(currentCustomer);
                context.SaveChanges();
                context.Dispose();

                //    // --------------------- Updating statistics and reseting the form: ---------------------

                //    updateStatistics();
                txtBxAccNmbr.Focus();
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
        }
    }
}
