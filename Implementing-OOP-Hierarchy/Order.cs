using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> items = new List<MenuItem>();
        public Order()
        {
        }
        public IReadOnlyCollection<MenuItem> Items => this.items.AsReadOnly();

        public void AddItem(MenuItem item)
        {
            this.items.Add(item);
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (MenuItem item in this.items)
            {
                total += item.Price;
            }
            return total;
        }
        public override string ToString()
        {
            return $"{string.Join("\n ", this.items)}";
        }
    }
}
