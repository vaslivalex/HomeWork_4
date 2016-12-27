using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorSet cs = new ColorSet();
            Car car = new Car("Mersedes", "ML350", 1300, 5, 18);
            Train train = new Train("Hyundai", "HRCS2", 5000000, 25, "пассажирский");
            Airplane airplane = new Airplane("Boeing", "747-400", 442000, 2, 64);

            Console.Write("Свойства объекта \"Автомобиль\": ");
            cs.color(car);
            Console.WriteLine();
            Console.Write("Свойства объекта \"Поезд\": ");
            cs.color(train);
            Console.WriteLine();
            Console.Write("Свойства объекта \"Самолет\": ");
            cs.color(airplane);
            Console.WriteLine();
        }
    }
}
