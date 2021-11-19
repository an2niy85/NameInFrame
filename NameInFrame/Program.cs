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

            Console.Clear();
            for (int i = 0; i <= someName.Length + 1; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.SetCursorPosition(i, j);
                    if (i >=1 && i <=someName.Length && j == 1)
                    {
                        Console.Write(someName[i - 1]);
                    }
                    else
                    {
                        Console.Write(symbolFrame);
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
