using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HomeWork4
{
    class ColorSet
    {
        public void color(object o)
        {
            Type type = o.GetType();
            foreach (PropertyInfo info in type.GetProperties())
            {
                if (info.IsDefined(typeof(ConsolColorAttribute)))
                {
                    ConsolColorAttribute colorAttribute = info.GetCustomAttribute(typeof(ConsolColorAttribute), true) as ConsolColorAttribute;
                    Console.ForegroundColor = colorAttribute.ConsColor;
                    Console.Write(info.GetValue(o) + " ");
                    Console.ResetColor();

                }
                else
                {
                    Console.Write(info.GetValue(o));
                }
            }
        }
    }
}
