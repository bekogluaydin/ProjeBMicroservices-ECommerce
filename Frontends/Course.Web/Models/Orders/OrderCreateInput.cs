using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Models.Orders
{
    public class OrderCreateInput
    {
        public OrderCreateInput()
        {
            OrderItems = new List<OrderItemCreateInput>();
        }
        public string BuyerID { get; set; }
        public List<OrderItemCreateInput> OrderItems { get; set; }
        public AdressCreateInput Address { get; set; }
    }


}
