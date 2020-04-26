using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class LogClass
    {
        public static void WriteToFile(List<ILog> ChangedElements)
        {
            foreach (var element in ChangedElements)
            {
                Console.WriteLine(element.Log());
            }
        }
    }
}
