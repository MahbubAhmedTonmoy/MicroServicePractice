using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MS1.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quntity { get; set; }
    }
}
