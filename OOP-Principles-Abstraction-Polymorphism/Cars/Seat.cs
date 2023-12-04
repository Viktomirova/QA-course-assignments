using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Color} Seat {Model}");
            sb.AppendLine("Engine start");
            sb.AppendLine("Break!");

            return sb.ToString().TrimEnd();
        }
    }
}
