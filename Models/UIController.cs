using Labb_1_Marcus_Hellkvist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class UIController : IObserver
    {
        public void Update(ISubject subject, int flag)
        {
            Cart? cart = subject as Cart;
            if (cart != null)
            {
                switch (flag)
                {
                    case 0:
                        Console.WriteLine(cart.Items.LastOrDefault().Key.Name + " added to the shopping cart");
                        break;
                    case 1:
                        Console.WriteLine("Item removed from the shopping cart");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
