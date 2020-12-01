using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thred
{
    class Amount
    {
        double NetBalance = 50000;
        double transaction;




        public void deposit()
        {
            NetBalance = NetBalance + transaction;
            Console.WriteLine(NetBalance);
        }




        public void withdrawal()
        {
            NetBalance = NetBalance - transaction;
            Console.WriteLine(NetBalance);
        }




        public  Amount(double transaction)
        {
            this.transaction = transaction;
        }
        public double Netbalance
        {
            get
            {
                return NetBalance;
            }
            set
            {
                NetBalance = value;
            }
        }


    }
}
