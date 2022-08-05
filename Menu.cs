using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLSTest
{
    public class Menu
    {
        public static void PrintMenu(List<MenuItem> items)
        {
            Console.WriteLine(string.Join("\n", items.Select(x => $"[{x.Id}]. {x.Text}")));
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }

    public class MenuItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Action Action { get; set; }
    }
}
