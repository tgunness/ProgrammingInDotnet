using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Week2.InClassDemo
{
    public class Account
    {
        public Account()
        {
            
        }
        public Account(string name, string address,bool isActive)
        {
            Name = name;
            Address = address;
            this.isActive = isActive;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool isActive { get; set; }
    }
}
