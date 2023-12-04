using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<Customer> customers = new List<Customer>();
        private List<MenuItem> menu = new List<MenuItem>();
        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }
        public MenuItem GetMenuItem(int index)
        {
            if (this.menu.Count < index && index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return this.menu[index];
        }
        public void AddMenuItem(MenuItem item)
        {
            this.menu.Add(item);
        }
        public void PlaceOrder(Customer customer, Order order) 
        {
            customer.AddOrder(order);
        }
        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach (MenuItem item in menu)
            {
                Console.WriteLine(item);
            }
        }
        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");
            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: ${order.GetTotal()}");
            }
            foreach (Order item in customer.OrderHistory)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine();
        }
    }
}
