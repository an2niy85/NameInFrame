using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            string someName;
            char symbolFrame;

            Console.WriteLine("Введите ваше имя");
            someName = Console.ReadLine();
            Console.WriteLine("Введите символ рамки");
            symbolFrame = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i <= someName.Length + 1; i++) {
                Console.Write(symbolFrame);}
            Console.WriteLine("\n" + symbolFrame + someName + symbolFrame);
            for (int i = 0; i <= someName.Length + 1; i++) {
                Console.Write(symbolFrame);}
            Console.ReadLine();
        }
    }
}
