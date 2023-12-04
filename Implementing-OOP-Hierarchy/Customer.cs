using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _orderHistory = new List<Order>();
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly();
        public void AddOrder(Order order)
        {
            _orderHistory.Add(order);
        }
    }
}
