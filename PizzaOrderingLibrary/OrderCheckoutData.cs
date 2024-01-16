using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingLibrary
{
    public class OrderItemData
    {
        public string PizzaType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class OrderCheckoutData
    {
        public readonly object TotalAmount;
        private List<OrderItemData> orderItems = new List<OrderItemData>();

        public object OrderItems { get; set; }
    }
}
