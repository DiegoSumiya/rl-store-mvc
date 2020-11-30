using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagementMVC.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public int Status { get; set; }
        public double Total { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int PaymentForm { get; set; }
    
    }
}
