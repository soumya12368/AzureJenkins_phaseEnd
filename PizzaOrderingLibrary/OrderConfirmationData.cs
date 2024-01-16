using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingLibrary
{
    public class OrderConfirmationData
    {
        public string OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PizzaType { get; set; }
    }
}
