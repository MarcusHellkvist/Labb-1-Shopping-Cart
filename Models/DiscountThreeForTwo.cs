using Labb_1_Marcus_Hellkvist.Interface;

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class DiscountThreeForTwo : IDiscount
    {
        public int calculateDiscount(Dictionary<Item, int> cart)
        {
            int totalDiscount = 0;
            foreach (var item in cart)
            {
                if (item.Value == 3)
                {
                    totalDiscount += item.Key.Price;
                }
            }
            return totalDiscount;
        }
    }
}
