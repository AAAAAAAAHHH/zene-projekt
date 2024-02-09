using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using proj;

namespace zene_proj
{
    internal class forras
    {
        menuControl menu = new menuControl();

        List<string> eloado = new List<string>();
        List<string> cim = new List<string>();
        List<string> mufajok = new List<string>();

        public void feltolt()
        {
            string[] file = File.ReadAllLines("zeneprojekt.txt");

            for (int i = 0; i < file.Length; i++)
            {
                string[] sor = file[i].Split(';');

                eloado.Add(sor[0]);
                cim.Add(sor[1]);
                mufajok.Add(sor[2]);
            }
        }

        public void kiir()
        {
            int maxEloado = 0; 

            foreach (string item in eloado) 
            {
                if (item.Length > maxEloado)
                {
                    maxEloado = item.Length;
                }
            }

            int maxCim = 0;

            foreach (string item in cim)
            {
                if (item.Length > maxCim)
                {
                    maxCim = item.Length;
                }
            }

            for (int i = 0; i < eloado.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{eloado[i]}  ");

                Console.SetCursorPosition(maxEloado + 2, i);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{cim[i]}  ");

                Console.SetCursorPosition(maxEloado + maxCim + 4, i);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{mufajok[i]}");
            }

            Console.ForegroundColor = ConsoleColor.White;

            menu.returnToMenu();
        }
    }
}
