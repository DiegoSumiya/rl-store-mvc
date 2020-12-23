using SalesManagementMVC.Data;
using SalesManagementMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesManagementMVC.Services
{
    public class OrderService
    {
        private readonly SalesManagementMVCContext _context;

        public OrderService(SalesManagementMVCContext context)
        {
            _context = context;
        }

        public List<Order> FindAll()
        {
            return _context.Order.OrderBy(x => x.Name).ToList();
        }
    }
}
