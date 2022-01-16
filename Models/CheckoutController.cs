using Labb_1_Marcus_Hellkvist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Marcus_Hellkvist.Models
{
    abstract class CheckoutController
    {
        public static void CheckOut(Cart cart) 
        {
            Console.WriteLine("-------------[C A R T]-------------");
            foreach (var item in cart.Items)
            {

                Console.WriteLine(item.Value + " x " + item.Key.Name + "        $" + (item.Key.Price * item.Value) + " (á " + (item.Key.Price) + ")");
                if (item.Value >= 3)
                {
                    Console.WriteLine("---> Discount added!");
                }

            }
            Console.WriteLine();
            Console.WriteLine("-------------[D I S C O U N T S]-------------");
            foreach (var discount in cart.Discounts)
            {
                if (discount > 0)
                {
                    Console.WriteLine("-$" + discount);
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------[C H E C K O U T]-------------");
            Console.WriteLine("Total Price: $" + cart.GetTotalPrice());
            Console.WriteLine("Discount: -$" + cart.GetTotalDiscount());
            Console.WriteLine("You Pay: $" + cart.GetTotalPriceWithDiscount());
            Console.WriteLine("-------------------------------------");
        }

        public static bool Pay(IPayment paymentMethod, Cart cart)
        {
            return paymentMethod.Pay(cart.GetTotalPriceWithDiscount());
        }
    }
}
