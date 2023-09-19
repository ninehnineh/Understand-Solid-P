using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    internal class ShoppingCartServices
    {
        private List<ShoppingCartModel> items = new List<ShoppingCartModel>();

        public IEnumerable<ShoppingCartModel> Items { get { return items; } }

        public void Add(ShoppingCartModel item) => items.Add(item);

        public void Remove(ShoppingCartModel item) => items.Remove(item);

        public double GetTotal() => items.Sum(i => i.Quantity * i.Price);

        public void Clear() => items.Clear();

        public void Print()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Title} - {item.Price:C} x {item.Quantity} = {item.Quantity * item.Price:C}");
            }
        }

        public void SaveToFile(string fileName) => Console.WriteLine("Write file success...");

        public void LoadFromFile(string fileName) => Console.WriteLine("Load file success...");
    }
}
