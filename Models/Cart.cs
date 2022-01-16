using Labb_1_Marcus_Hellkvist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class Cart
    {
        public Dictionary<Item, int> Items = new Dictionary<Item, int>();
        public List<int> Discounts { get; set; } = new List<int>();

        public void CalculateDiscount(IDiscount discountMethod)
        {
            var discount = discountMethod.calculateDiscount(Items);
            Discounts.Add(discount);
        }

        public void AddItem(Item item) 
        {
            if (!Items.ContainsKey(item))
            {
                Items.Add(item, 1);
            }
            else
            {
                Items[item] += 1;
            }
        }

        public void RemoveItem(Item item)
        {
            if (Items.ContainsKey(item)) 
            {
                Items[item] -= 1;
                if (Items[item] <= 0)
                {
                    Items.Remove(item);
                }
            }
        }

        public int GetTotalPriceWithDiscount()
        {
            return GetTotalPrice() - GetTotalDiscount();
        }

        public int GetTotalPrice()
        {
            var totalPrice = 0;

            foreach (var item in Items)
            {
                totalPrice += (item.Key.Price * item.Value);
            }
            return totalPrice;
        }

        public int GetTotalDiscount() 
        {
            int discount = 0;
            foreach (var d in Discounts)
            {
                discount += d;
            }
            return discount;
        }
    }
}
