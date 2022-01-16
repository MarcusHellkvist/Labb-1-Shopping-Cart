using Labb_1_Marcus_Hellkvist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class Cart : ISubject
    {
        public Dictionary<Item, int> Items = new Dictionary<Item, int>();
        public List<int> Discounts { get; set; } = new List<int>();
        private readonly List<IObserver> _observers = new List<IObserver>();

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
            Notify();
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

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
