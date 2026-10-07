using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public static class Input
    {
        public static string ReadNonEmpty(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(s)) return s;
                Console.WriteLine("Значение не может быть пустым");
            }
        }
        public static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int n) && n > 0)
                {
                    return n;
                }
                Console.WriteLine("Число не может быть отрицательным или 0");
            }
        }
    }
}
