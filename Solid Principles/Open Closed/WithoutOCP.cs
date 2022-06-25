using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Open_Closed
{
    //Example: Without using the Open-Closed Principle in C#

    /// <summary>
    /// As you can see in the above image, within the Invoice class we have created the GetInvoiceDiscount() method. As part of that GetInvoiceDiscount()
    /// method we are calculating the final amount based on the Invoice type. As of now, we have two Invoice Types as the Final
    /// Invoice and the Proposed Invoice. So we have implemented the logic using if-else. Tomorrow, if one more Invoice 
    /// Type comes into the picture then we need to modify the GetInvoiceDiscount() method logic by adding another else if
    /// block to the source code. As we are changing the source code for the new requirement,
    /// we are violating the Open-Closed principle in C#. 
    /// </summary>
    /// 
    public class Invoice
    {
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }
    }
    /// <summary>
    /// If we are changing the Invoice class again and again then we need to ensure that the previous 
    /// functionalities along with the new functionalities are working properly by testing both the 
    /// functionalities again. This is because we need to ensure that the existing clients, which are
    /// referencing this class are working properly as expected 
    /// or not.
    /// </summary>
    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    };
}
