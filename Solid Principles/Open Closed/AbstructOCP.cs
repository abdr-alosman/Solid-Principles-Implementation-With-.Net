using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Open_Closed
{
    public abstract class InvoiceAbstructOCP
    {
        public abstract double GetInvoiceDiscount(double amount);
        
       
    }
    public class FinalInvoiceAbstruct : InvoiceAbstructOCP
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
    public class ProposedInvoiceAbstruct : InvoiceAbstructOCP
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - 40;
        }
    }
    public class RecurringInvoiceAbstruct : InvoiceAbstructOCP
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - 30;
        }
    }
}
