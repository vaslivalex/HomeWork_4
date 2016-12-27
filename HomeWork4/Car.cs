using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Car : Transport
    {
        [ConsolColor(ConsoleColor.Yellow)]
        public byte NumberOfDoors { get; set; }
       
        [ConsolColor(ConsoleColor.Green)]
        public int DiameterOfWeels { get; set; }
        public Car(string brand, string model, int weight, byte numberOfDoors, int diameterOfWeels)
            : base (brand, model, weight)
        {
            NumberOfDoors = numberOfDoors;
            DiameterOfWeels = diameterOfWeels;
        }
    }
}
