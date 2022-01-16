using Labb_1_Marcus_Hellkvist.Interface;

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class DiscountTenPercent : IDiscount
    {
        public int calculateDiscount(Dictionary<Item, int> cart)
        {
            int totalDiscount = 0;
            int totalPrice = 0;

            foreach (var item in cart) 
            {
                totalPrice += (item.Key.Price * item.Value);
            }

            if (totalPrice > 500) 
            {
                totalDiscount = (int)(totalPrice * 0.1);
            }
            return totalDiscount;
        }
    }
}
