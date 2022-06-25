using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Open_Closed
{
    public interface IInvoice
    {
        double GetInvoiceDiscount(double amount);
    }
    public class FinalInvoiceInterface : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
    public class ProposedInvoiceInterface : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 40;
        }
    }
    public class RecurringInvoiceInterface : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 30;
        }
    }
}
