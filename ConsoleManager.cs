using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKadmin
{
    internal class ConsoleManager
    {
        public static void SetOutputEncoding()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void WriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        public static void ReadLineAndPause()
        {
            Console.ReadLine();
        }
    }
}