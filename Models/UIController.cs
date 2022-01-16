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
        public void Update(ISubject subject)
        {
            var s = subject as Cart;
            if (s != null)
            {
                Console.WriteLine(s.Items.LastOrDefault().Key.Name + " added to the shopping cart");
            }
            
        }
    }
}
