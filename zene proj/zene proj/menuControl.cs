using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zene_proj;

namespace proj
{
    internal class menuControl

    {
        public void returnToMenu()
        {
            forras forras = new forras();

            forras.feltolt();

            ConsoleKeyInfo keyInfo;

            keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Backspace)
            {

                Console.Clear();

                int menuIndex = this.Menu();

                Console.Clear();

                switch (menuIndex)
                {
                    case 0:
                        break;

                    case 1:
                        break;

                    case 2:
                        forras.kiir();
                        break;
                }
            }

        }
        public int Menu()
        {
            // A menüpontok neve
            string[] menu =
            {
                "Zene ajánlás",
                "Műsorlista ajánlás",
                "Zenék megtekintése",
            };

            // Ez a váltzó tárolja a lenyomott billentyű adatait
            ConsoleKeyInfo keyInfo;

            // A jelenlegi menüpont indexe
            int currentMenu = 0;

            // Eltünteti a kurzort
            Console.CursorVisible = false;

            Console.WriteLine("Zene ajánló program");

            do
            {
                // A kurzor pozíciójának visszállítása, hogy az előző szöveget felülírja
                Console.SetCursorPosition(0, 2);

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

                // Nyíl inputra vár, és elmenti hogy melyik billentyűt nyomtuk le
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
                        if (currentMenu != menu.Length - 1)
                        {
                            currentMenu += 1;
                        }
                        // Ha nincs, akkor visszaugrik a menü aljára
                        else
                        {
                            currentMenu = 0;
                        }
                        break;
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Enter);

            return currentMenu;
        }
    }
}
