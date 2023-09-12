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
        private string _id;
        private readonly string _uid;

        public Account()
        {
                
        }
        public Account(string name, string address,bool isActive)
        {
            Name = name;
            Address = address;
            this.isActive = isActive;
            _id = "1231234";
            _uid = "123123412123";
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool isActive { get; set; }

        public string GetId()
        {
            return _id;
        }

        public override string ToString()
        {
            return $"{Name}{Address}";
        }
    }
}
