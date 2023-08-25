using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    public partial class Customer
    {

        // -------------------------------- 1st constructor method: --------------------------------

        public Customer()
        {
        }


        // -------------------------------- 2nd constructor method: --------------------------------

        public Customer(int accNo, string fstNm, string lstNm)
        {
            AccountNumber = accNo;
            FirstName = fstNm;
            LastName = lstNm;
        }


        // -------------------------------- 2nd constructor method: --------------------------------

        public Customer(string fstNm, string lstNm)
        {
            Guid uniqueId = Guid.NewGuid();
            int hashedValue = Math.Abs(uniqueId.GetHashCode());

            AccountNumber = hashedValue;
            FirstName = fstNm;
            LastName = lstNm;
        }


        // ------------------ calculate ToString method (method for MessageBox): ------------------

        public override string ToString()
        {
            return $"Add {FirstName} {LastName} with account no. {AccountNumber}";
        }


        public string UpdateCustomer()
        {
            return $"Update customer's info with account no. {AccountNumber} to {FirstName} {LastName}";
        }
    }
}
