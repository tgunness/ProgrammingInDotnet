using CarDealership.Models;
using CarDealership.View;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarDealership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dealership dealer = new Dealership(); //containing all business login inside a Dealership class increases reusablability
            SalesView salesView = new SalesView(dealer);  //putting views into classes increase expandability (ie. we can add more and more view (SalesView, MaintainanceView, etc.))

            salesView.Display();
        }       
    }
}
