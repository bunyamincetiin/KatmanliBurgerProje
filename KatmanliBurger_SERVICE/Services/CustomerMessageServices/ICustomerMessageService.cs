using KatmanliBurger_DATA.Concretes;

namespace KatmanliBurger_SERVICE.Services.CustomerMessageServices
{
    public interface ICustomerMessageService
    {
        void Create(CustomerMessage entity);
        void Update(CustomerMessage entity);
        void UpdateStatus(int id);
        CustomerMessage GetById(int id);
        IEnumerable<CustomerMessage> GetAll();
    }
}
