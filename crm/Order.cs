using System;
using System.Collections.Generic;
using System.Text;

namespace crm
{
    class Order
    {
        public string OrderID { get; set; }
        public string DeliveryAdress { get; set; }
        public string TotalAmount { get; private set; }


    }
}