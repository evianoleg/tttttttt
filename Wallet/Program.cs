using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using money;
using CreditCard;

namespace Wallet
{
    class Program
    {
        static void Main(string[] args)
        {

            Money m = new Money();
            
            
            int myMoney = 100;
            Card c = new Card();
            c.cred = 1000;
            myMoney += c.cred;
            myMoney += 1000;
        }
    }
}
