using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Open_Closed
{
    public class InvoiceOCP
    {
        // virtual: any class that inherit from InvoiceOCP will be able to change the implementation to this
        // method, by overriding method
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }
    public class FinalInvoice : InvoiceOCP
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : InvoiceOCP
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    /// <summary>
    /// As you can see in the above code, we have created three classes FinalInvoice, ProposedInvoice, 
    /// and RecurringInvoice. All these three classes are inherited from the base class Invoice and if 
    /// they want then they can override the GetInvoiceDiscount() method. Tomorrow if another Invoice 
    /// Type needs to be added then we just need to create a new class by inheriting it from the Invoice
    /// class. The point that you need to keep the focus on is we are not changing the code of the Invoice class.
    /// </summary>
    public class RecurringInvoice : InvoiceOCP
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
    
}

