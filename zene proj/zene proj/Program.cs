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

            menu.Menu();


            Console.ReadKey();

        }
    }
}
