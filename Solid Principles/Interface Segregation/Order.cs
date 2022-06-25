

namespace Solid_Principles.Interface_Segregation
{
    public class Order : IOrder
    {
        public void Complete()
        {
            throw new NotImplementedException();
        }

        public void newMethod()
        {
            throw new NotImplementedException();
        }

        public void ProcessCachInvoce()
        {
            throw new NotImplementedException();
        }

        public void ProcessCreditInvoce()
        {
            throw new NotImplementedException();
        }

        public void ProcessOnlineInvoce()
        {
            throw new NotImplementedException();
        }
    }
}
