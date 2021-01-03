using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagementMVC.Models.ViewModels
{
    public class OrderDetailsFormViewModel
    {
        public Order Order { get; set; }
        public OrderItem OrderItem { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
