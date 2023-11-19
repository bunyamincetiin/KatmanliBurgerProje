using KatmanliBurger_DATA.Concretes;
using KatmanliBurger_DATA.DomainModels;

namespace KatmanliBurger_SERVICE.Services.BasketServices
{
    public interface IBasketService
    {
        void AddToBasket(Basket basket, ByProduct? product, Menu? menu, Burger? burger);
        void RemoveFromBasket(Basket basket, int? productId, int? menuId, int? burgerId, int? removeAll);

        ICollection<BasketLine> GetList(Basket basket);
    }
}
