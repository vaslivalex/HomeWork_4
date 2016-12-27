using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public abstract class Transport
    {
        [ConsolColor(ConsoleColor.Cyan)]
        public string Brand { get; set; }
        [ConsolColor(ConsoleColor.DarkCyan)]
        public string Model { get; set; }
        [ConsolColor(ConsoleColor.DarkRed)]
        public int Weight { get; set; }
        public Transport(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
}
