using Labb_1_Marcus_Hellkvist.Interface;

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class DiscountCheapestItem : IDiscount
    {
        public int calculateDiscount(Dictionary<Item, int> cart)
        {
            int totalDiscount = 0;
            int amount = 0;

            foreach (var item in cart)
            {
                amount += item.Value;
            }
            if (amount >= 10)
            {
                int cheapestPrice = cart.Any() ? cart.Min(item => item.Key.Price) : 0;
                totalDiscount = cheapestPrice;
            }

            return totalDiscount;
        }
    }
}
