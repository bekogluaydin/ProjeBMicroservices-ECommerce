﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Shared.Messages
{
    public class CreateOrderMessageCommand
    {
        public string BuyerID { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public string Province { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Line { get; set; }
    }

    public class OrderItem
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string PictureURL { get; set; }
        public Decimal Price { get; set; }
    }
}