using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagementMVC.Models.ViewModels
{
    public class OrderItemFormViewModel
    {
        public OrderItem OrderItem { get; set; }
        public ICollection<Order> Orders { get; set; }
        public string OrderId { get; set; }
    }
}
