using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Train : Transport
    {
        [ConsolColor(ConsoleColor.Red)]
        public byte NumberOfWagons { get; set; }
       
        [ConsolColor(ConsoleColor.Blue)]
        public string TypeOfTrain { get; set; }
        public Train(string brand, string model, int weight, byte numberOfWagons, string typeOfTrain)
            : base (brand, model, weight)
        {
            NumberOfWagons = numberOfWagons;
            TypeOfTrain = typeOfTrain;
        }
    }
}
