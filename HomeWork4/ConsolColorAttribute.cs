using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    [AttributeUsage(AttributeTargets.Property)]
    class ConsolColorAttribute : Attribute
    {
        public ConsoleColor ConsColor { get; set; }
        public ConsolColorAttribute(ConsoleColor consColor)
        {
            ConsColor = consColor;
        }
    }
}
