﻿using proj;
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
            forras forras = new forras();
            menuControl menu = new menuControl();

            forras.feltolt();

            

            menu.returnToMenu();

            Console.ReadKey();
        }
    }
}
