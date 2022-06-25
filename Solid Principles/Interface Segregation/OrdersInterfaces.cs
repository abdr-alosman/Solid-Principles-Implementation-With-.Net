

namespace Solid_Principles.Interface_Segregation
{
    public interface IOrder: ICashOrder, IOnlineOrder, ICreditOrder
    {
        void newMethod();
    }
    public interface ICashOrder { void ProcessCachInvoce();void Complete(); }
    public interface IOnlineOrder { void ProcessOnlineInvoce(); }
    public interface ICreditOrder { void ProcessCreditInvoce(); }
}
