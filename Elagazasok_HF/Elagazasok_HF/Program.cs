using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazasok_HF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            feladat1();

            feladat2();

            feladat3();

            feladat4();

            feladat5();

            feladat6();

            feladat7();

            feladat8();*/

            feladat9();

            feladat10();

            feladat11();

            feladat12();

            feladat13();

            feladat14();

            feladat15();

            feladat16();

            Console.ReadKey();
        }

        private static void feladat16()
        {
            throw new NotImplementedException();
        }

        private static void feladat15()
        {
            Console.WriteLine("\n15.Feladat");
            int melyseg;

            Console.Write("Írd be a balaton vízmélységét méterben: ");
            melyseg = Convert.ToInt32(Console.ReadLine());
            if (melyseg < 1)
            {
                Console.WriteLine("A vízben pancsolunk");
            }
            else if (melyseg >= 1 && melyseg <= 2)
            {
                Console.WriteLine("A vízben úszunk");
            }
            else if (melyseg > 2)
            {
                Console.WriteLine("A víz túl mély");
            }
        }

        private static void feladat14()
        {
            Console.WriteLine("\n14.Feladat");
            int szam;
            Console.WriteLine("Írj be egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam < 0)
            {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("A szám vagy nulla vagy pozitív");
            }
        }

        private static void feladat13()
        {
            Console.WriteLine("\n13.Feladat");
            int fok;
            Console.Write("Írd be hény fokos a víz: ");
            fok = Convert.ToInt32(Console.ReadLine());

            if (fok < 0)
            {
                Console.WriteLine("A víz halmazállapota: jég");
            }

            else if (fok >= 0 && fok < 100)
            {
                Console.WriteLine("A víz halmazállapota: folyékony");
            }

            else if (fok >= 100)
            {
                Console.WriteLine("A víz halmazállapota: gőz");
            }
        }

        private static void feladat12()
        {
            Console.WriteLine("\n12.Feladat");
            int szam1;
            int szam2;

            Console.Write("a értéke? = ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b értéke? = ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
            {
                Console.WriteLine("{0} kisebb, mint {1}", szam2, szam1);
            }
            else if (szam1 < szam2)
            {
                Console.WriteLine("{0} kisebb, mint {1}", szam1, szam2);
            }
            else
            {
                Console.WriteLine("{0} egyenlő {1}-val(vel)", szam1, szam2);
            }
        }

        private static void feladat11()
        {
            Console.WriteLine("\n11.Feladat");
            int eletkor;
            Console.WriteLine("Írd be hány éves vagy: ");
            eletkor = Convert.ToInt32(Console.ReadLine());

            if (eletkor < 14)
            {
                Console.WriteLine("Az életkor alapján, cselekvőképtelen vagy");
            }

            else if (eletkor >= 14 && eletkor <= 17)
            {
                Console.WriteLine("Az életkor alapján, korlátozottan cselekvőképes vagy");
            }
            else
            {
                Console.WriteLine("Az életkor alapján, nagykorú vagy");
            }
        }

        private static void feladat10()
        {
            Console.WriteLine("\n10.Feladat");
            int szam;
            Console.WriteLine("Írj be egy számot:");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam >= -50 && szam <= 50)
            {
                Console.WriteLine("A szám -50 és 50 közé esik");
            }
            else
            {
                Console.WriteLine("A szám nem esik -50 és 50 közé");
            }
        }

        private static void feladat9()
        {
            Console.WriteLine("\n9.Feladat");
            int szam;
            Console.WriteLine("Írj be egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam >= 50)
            {
                Console.WriteLine("50-nél nem kisebb");
            }

            else
            {
                Console.WriteLine("50-nél kisebb");
            }
            
        }

        private static void feladat8()
        {
            Console.WriteLine("8.Feladat");
            int szam;
            Console.WriteLine("Írj be egy számot:");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam > 0)
            {
                Console.WriteLine("A szám előjele: '+'");
            }
            if (szam < 0)
            {
                Console.WriteLine("A szám előjele: '-'");
            }
        }

        private static void feladat7()
        {
            Console.WriteLine("\n7.Feladat");
            int eletkor;
            Console.WriteLine("Írd be hány éves vagy: ");
            eletkor = Convert.ToInt32(Console.ReadLine());

            if (eletkor >= 18)
            {
                Console.WriteLine("Megnézheted a filmet");
            }
        }

        private static void feladat6()
        {
            int szam1;
            int szam2;
            Console.WriteLine("\n6.Feladat");
            Console.WriteLine("Írj be egy számot:");

            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Írj be még egyet:");

            szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
            {
                Console.WriteLine("A {0} nagyobb mint {1}", szam1, szam2);
            }
            if (szam1 < szam2)
            {
                Console.WriteLine("A {0} nagyobb mint {1}", szam2, szam1);
            }
        }

        private static void feladat5()
        {
            Console.WriteLine("\n5.Feladat");

            Console.WriteLine("Írj be még egy számot: ");
            int szam;
            szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
                Console.WriteLine("A szám osztható 2-vel");
            else
                Console.WriteLine("A szám nem osztható 2-vel");
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4.Feladat");

            Console.WriteLine("Írj be egy számot: ");

            string szam = Console.ReadLine();

            int szam_int = Convert.ToInt32(szam);

            if ((szam_int % 3) == 0)
            {
                Console.WriteLine("A szám osztható 3-mal");
            }

            if ((szam_int % 4) == 0)
            {
                Console.WriteLine("A szám osztható 4-gyel");
            }

            if ((szam_int % 9) == 0)
            {
                Console.WriteLine("A szám osztható 9-cel");
            }
        }

        private static void feladat3()
        {
            Console.WriteLine("\n3.Feladat");

            Console.WriteLine("Írj be egy szöveget: ");

            string szoveg = Console.ReadLine();

            if (szoveg.Contains(" "))
            {
                Console.WriteLine("A beírt szöveg több szóbol áll.");
                int hossz = szoveg.Length;
                Console.WriteLine("A szöveg: {0} karakterből áll.", hossz);
            }

        }

        private static void feladat2()
        {
            Console.WriteLine("\n2.Feladat");

            Console.WriteLine("Elköszönjek tőled?");

            string ask = Console.ReadLine();

            if (ask == "igen")
            {
                Console.WriteLine("Viszontlátásra!");
            }
        }

        private static void feladat1()
        {
            /*
                        Console.WriteLine("\n1.Feladat");

            Console.WriteLine("Írj be egy karaktert: ");

            char adat = Console.ReadLine();

            if (Char.IsLetter(adat))
            {
                Console.WriteLine("Ez egy betű");
            }
            */

        }
    }
}
