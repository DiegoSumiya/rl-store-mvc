using SalesManagementMVC.Models.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesManagementMVC.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public double Total { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public PaymentForm PaymentForm { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(string id, string customerId, string name, Status status, double total, DateTime created, DateTime updated, PaymentForm paymentForm)
        {
            Id = id;
            CustomerId = customerId;
            Name = name;
            Status = status;
            Total = total;
            Created = created;
            Updated = updated;
            PaymentForm = paymentForm;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

      
    }
}
