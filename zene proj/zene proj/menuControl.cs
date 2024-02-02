using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class menuControl
    {
        public void Menu()
        {
            // A menüpontok neve
            string[] menu =
            {
                "Menüpont 1",
                "Menüpont 2",
                "Menüpont 3",
                "Menüpont 4",
            };

            // Ez a váltzó tárolja a lenyomott billentyű adatait
            ConsoleKeyInfo keyInfo;

            // A jelenlegi menüpont indexe
            int currentMenu = 0;

            do
            {
                // A konozol törlése, hogy frissíteni tudja
                Console.Clear();

                Console.WriteLine();

                // A menüpontok kiíratása
                for (int i = 0; i < menu.Length; i++)
                {
                    // Ha a kiírandó menüpont jelenleg ki van választva, akkor átszínezi pirosra
                    if (currentMenu == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(menu[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(menu[i]);
                    }
                }

                // Nyíl inputra vár
                keyInfo = Console.ReadKey();

                // Megnézi, hogy melyik billentyűt nyomtuk le
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                    {
                        // Ha van lefelé hely akkor lefelé megy
                        if (currentMenu == 0)
                        {
                            currentMenu = menu.Length - 1;
                        }
                        // Ha nincs, akkor visszaugrik a menü elejére
                        else
                        {
                            currentMenu -= 1;
                        }

                        break;
                    }

                    case ConsoleKey.DownArrow:
                    {
                        // Ha van felfelé hely akkor felfelé megy
                        if (currentMenu == menu.Length - 1)
                        {
                            currentMenu = 0;
                        }
                        // Ha nincs, akkor visszaugrik a menü aljára
                        else
                        {
                            currentMenu += 1;
                        }
                        break;
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
