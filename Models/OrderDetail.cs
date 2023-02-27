using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiFramework.Models
{
    // Many to Many
    public class OrderDetail
    {
        public int Id {get; set;}
        public int Quantity {get; set;}
        public int ProductId {get; set;}
        public int OrderId {get; set;}
        public Order Order {get; set;} = null;
        public Products Product {get; set;} = null;
    }
}