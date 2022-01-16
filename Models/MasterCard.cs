using Labb_1_Marcus_Hellkvist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Marcus_Hellkvist.Models
{
    public class MasterCard : IPayment
    {
        public int Balance { get; set; }

        public MasterCard(int money)
        {
            Balance = money;
        }
        public bool Pay(int amount)
        {
            if (Balance >= amount) 
            {
                return true;
            }
            return false;
        }
    }
}
