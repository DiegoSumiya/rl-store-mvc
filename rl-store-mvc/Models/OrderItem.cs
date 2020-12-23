using System;


namespace SalesManagementMVC.Models
{
    public class OrderItem
    {
        public string Id { get; set; }
        public int Count { get; set; }
        public double UnitValue { get; set; }
        public double Total { get; set; }
        public string ProductName { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(string id, int count, double unitValue, double total, string productName, Order order)
        {
            Id = id;
            Count = count;
            UnitValue = unitValue;
            Total = total;
            ProductName = productName;
            Order = order;
        }
    }
}
