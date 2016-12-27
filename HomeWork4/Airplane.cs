using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Airplane : Transport
    {
        [ConsolColor(ConsoleColor.DarkYellow)]
        public byte NumberOfEngines { get; set; }
        
        [ConsolColor(ConsoleColor.DarkRed)]
        public int Wingspan { get; set; }
        public Airplane(string brand, string model, int weight, byte numberOfEngines, int wingspan)
            : base (brand, model, weight)
        {
            NumberOfEngines = numberOfEngines;
            Wingspan = wingspan;
        }
    }
}
