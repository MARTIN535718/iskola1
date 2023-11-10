using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valtozokgyak
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            feladat1();

            feladat2();

            feladat3();

            feladat4();

            feladat5();

            feladat6();

            feladat8();

            feladat9();

            Console.ReadLine();


        }

        private static void feladat9()
        {
            Console.WriteLine("Mennyi a kocsi havi adója? ");
            string ado = Console.ReadLine();
            Console.WriteLine("Mennyibe kerül a garázs? ");
            string garazs = Console.ReadLine();
            Console.WriteLine("Mennyi a javítási költsége?  ");
            string javitas = Console.ReadLine();
            Console.WriteLine("Mennyi a benzin havonta? ");
            string benzin = Console.ReadLine();
            Console.WriteLine("Mennyi a havi megtett távolság az autóval?(km) ");
            string km = Console.ReadLine();

            int osszeg = 

            osszeg = ado + garazs + javitas + benzin;


        }

        private static void feladat8()
        {

            Console.Write("Mekkora a kör átmérője? ");
            string sugar = Console.ReadLine();
            double szam = double.Parse(sugar);
            double szamitas = (szam * szam) * 3.14;
            double osszeg = szamitas * 2500 / 2;

            Console.WriteLine("Ennyi négyzetméter gyepet kell lerakni {0}, Ami ennyibe kerül: {1}", szamitas, osszeg);
            
        }

        private static void feladat7()
        {
            /*int dobas = 3;
            int fizetes = 50000;
            char karakter = 2;*/
        }

        private static void feladat6()
        {
           
            int eredmeny = (365 * 3000) * 300;

            Console.WriteLine("{0}ft-ba kerül 1 évre az összes tehén tartása.", eredmeny);
        }

        private static void feladat5()
        {
            Console.WriteLine("Kothencz Martin");

            
        }

        private static void feladat4()
        {
            int a = 8;
            int ma = 6;

            int t = (a * ma) / 2;

            Console.WriteLine("A háromszög területe: {0}", t);
        }

        private static void feladat3()
        {
            double a = 3.7;
            double b = 4.8;
            double c = 2.4;

            double eredmeny = a + b + c;
            double er_fele = eredmeny / 2;
            Console.WriteLine("Az eredmény: {0}, A fele: {1}", eredmeny, er_fele);
        }

        private static void feladat2()
        {
            string vnev = "Kothencz";
            string knev = "Martin";

            Console.WriteLine("{0} {1}", vnev, knev);
        }

        private static void feladat1()
        {
            Console.WriteLine("Kothencz Martin");

         

            int szamszor = 35 * 2;
            int szam2szor = 47 * 2;

            int eredmeny = szamszor + szam2szor;

            Console.WriteLine("Az eredmény {0}", eredmeny);

            //Console.WriteLine("A két értéket megszorozva kettővel és összeadva, ennyit kapunk: {0}", (35*2) + (47*2));

        }
    }
}
