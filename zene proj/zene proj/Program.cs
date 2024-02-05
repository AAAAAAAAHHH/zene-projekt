using proj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zene_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menuControl menu = new menuControl();

            int menuIndex = menu.Menu();

            Console.Clear();

            Console.WriteLine($"\nKiválsztott menüpont: {menuIndex+1}");


            Console.ReadKey();
        }
    }
}
