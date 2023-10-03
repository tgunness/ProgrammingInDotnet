using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//this is inline comment

namespace Week2.InClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.Name = "Trishan";
            myAccount.Address = "someAddress";

            var myAccount3 = new Account()
            {
                Name = "Trishan",
                Address = "someAddressIhave",
                isActive = false
            };

            Console.Write(myAccount);
            Console.ReadLine();

        }
    }
}
