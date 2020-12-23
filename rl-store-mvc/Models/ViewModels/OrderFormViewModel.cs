using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagementMVC.Models.ViewModels
{
    public class OrderFormViewModel
    {
        public OrderItem OrderItem { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
