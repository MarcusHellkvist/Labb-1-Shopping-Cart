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
        public int TotalDiscount { get; set; }

        public void CalculateDiscount(IDiscount discountMethod) 
        {
            var discount = discountMethod.calculateDiscount(Items);
            TotalDiscount += discount;
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

        public void ShowCart()
        {
            Console.WriteLine("-------------[C A R T]-------------");
            foreach (var item in Items)
            {
                Console.WriteLine(item.Value + " x " + item.Key.Name + "        $" + (item.Key.Price * item.Value) + " (á " + (item.Key.Price) + ")");
               
            }
            Console.WriteLine();
            Console.WriteLine("-------------[C H E C K O U T]-------------");
            Console.WriteLine("Total Price: $" + TotalPrice());
            Console.WriteLine("Discount: -$" + TotalDiscount);
            Console.WriteLine("You Pay: $" + TotalPriceWithDiscount());
            Console.WriteLine("-------------------------------------");
        }

        public int TotalPriceWithDiscount()
        {
            return TotalPrice() - TotalDiscount;
        }

        public int TotalPrice()
        {
            var totalPrice = 0;

            foreach (var item in Items)
            {
                totalPrice += (item.Key.Price * item.Value);
            }
            return totalPrice;
        }
    }
}
