using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    public partial class Invoice
    {
        // ------------------------------------- Variables: -------------------------------------

        decimal adminFee = 12;
        decimal kwhCost = 0.07m;


        // -------------------------------- 1st constructor method: --------------------------------

        //public Invoice(int accNo, decimal pwrUsg, DateOnly date)
        //{
        //    AccountNumber = accNo;
        //    PowerUsage = pwrUsg;
        //    InvoiceTotal = CalculateCharge();
        //    InvoiceDate = date.ToDateTime(TimeOnly.MinValue);
        //}


        //// -------------------------------- 2nd constructor method: --------------------------------

        //public Invoice(decimal pwrUsg, DateOnly date)
        //{
        //    Guid uniqueId = Guid.NewGuid();
        //    int hashedValue = Math.Abs(uniqueId.GetHashCode());

        //    AccountNumber = hashedValue;
        //    PowerUsage = pwrUsg;
        //    InvoiceTotal = CalculateCharge();
        //    InvoiceDate = date.ToDateTime(TimeOnly.MinValue);
        //}


        // -------------------------------- calculate cost method: --------------------------------

        //private decimal CalculateCharge()
        //{
        //    decimal powerCost = 0;
        //    powerCost = kwhCost * PowerUsage + adminFee;
        //    return powerCost;
        //}


        // ------------------ calculate ToString method (method for MessageBox): ------------------

        //public override string ToString()
        //{
        //    string billString = CalculateCharge().ToString("C");
        //    return $"Add account no. {AccountNumber} with a bill of {billString}";
        //}
    }
}
