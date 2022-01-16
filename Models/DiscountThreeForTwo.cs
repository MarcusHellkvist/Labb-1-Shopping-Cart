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
                double times = (item.Value / 3);
                for (int i = 0; i < times; i++)
                {
                    totalDiscount += item.Key.Price;
                }
            }
            return totalDiscount;
        }
    }
}
