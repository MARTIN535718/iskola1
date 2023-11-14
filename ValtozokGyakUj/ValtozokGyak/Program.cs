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

            feladat10();

            feladat13();

            feladat14();

            Console.ReadLine();


        }

        private static void feladat14()
        {
            Console.WriteLine("Adj meg egy számot: ");
            string a = Console.ReadLine();
            double e_a = Convert.ToDouble(a);

            Console.WriteLine("Még egyet: ");

            string b = Console.ReadLine();
            double e_b = Convert.ToDouble(b);

            double szke = (e_a + e_b) / 2;

            //double ertek = a * b;

            double mke = Math.Sqrt(e_a * e_b);

            Console.WriteLine("A számtani közép értéke: {0}, A mértani közép értéke: {1}", szke, mke);

        }

        private static void feladat13()
        {
            Console.WriteLine("Írj be egy hosszúságot cm-ben: ");
            string cm = Console.ReadLine();
            double e_cm = Convert.ToDouble(cm);

            double inch = 2.54;
            double osszeg = (1 / inch) * e_cm;

            Console.WriteLine("{0}cm = {1}inch", e_cm, osszeg);
        }

        private static void feladat10()
        {
            Console.WriteLine("\n10.Feladat\n");

            string elso = Console.ReadLine();
            int e_elso = Convert.ToInt32(elso);
            string masodik = Console.ReadLine();
            int e_masodik = Convert.ToInt32(masodik);
            string harmadik = Console.ReadLine();
            int e_harmadik = Convert.ToInt32(harmadik);
            string negyedik = Console.ReadLine();
            int e_negyedik = Convert.ToInt32(negyedik);

            Console.WriteLine("{0}{1}{2}{3}", e_negyedik, e_harmadik, e_masodik, e_elso);


        }

        private static void feladat9()
        {

            Console.WriteLine("\n9.Feladat\n");
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

            int e_ado = Convert.ToInt32(ado);
            int e_garazs = Convert.ToInt32(garazs);
            int e_javitas = Convert.ToInt32(javitas);
            int e_benzin = Convert.ToInt32(benzin);
            int e_km = Convert.ToInt32(km);

            int osszeg = e_ado + e_garazs + e_javitas + e_benzin;

            int km_ho = osszeg / e_km;

            Console.WriteLine("Az autó {0}ft/km-be kerül havonta.", km_ho);

        }

        private static void feladat8()
        {
            Console.WriteLine("\n8.Feladat\n");
            Console.Write("Mekkora a kör átmérője? ");
            string sugar = Console.ReadLine();
            double szam = double.Parse(sugar);
            double szamitas = (szam * szam) * 3.14;
            double osszeg = szamitas * 2500 / 2;

            Console.WriteLine("Ennyi négyzetméter gyepet kell lerakni {0}, Ami ennyibe kerül: {1}", szamitas, osszeg);
            
        }

        private static void feladat7()
        {
            Console.WriteLine("\n7.Feladat\n");
            /*int dobas = 3;
            int fizetes = 50000;
            char karakter = 2;*/
        }

        private static void feladat6()
        {
            Console.WriteLine("\n6.Feladat\n");
            int eredmeny = (365 * 3000) * 300;

            Console.WriteLine("{0}ft-ba kerül 1 évre az összes tehén tartása.", eredmeny);
        }

        private static void feladat5()
        {
            Console.WriteLine("\n5.Feladat\n");
            Console.WriteLine("Kothencz Martin");

            
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4.Feladat\n");
            int a = 8;
            int ma = 6;

            int t = (a * ma) / 2;

            Console.WriteLine("A háromszög területe: {0}", t);
        }

        private static void feladat3()
        {
            Console.WriteLine("\n3.Feladat\n");
            double a = 3.7;
            double b = 4.8;
            double c = 2.4;

            double eredmeny = a + b + c;
            double er_fele = eredmeny / 2;
            Console.WriteLine("Az eredmény: {0}, A fele: {1}", eredmeny, er_fele);
        }

        private static void feladat2()
        {
            Console.WriteLine("\n2.Feladat\n");
            string vnev = "Kothencz";
            string knev = "Martin";

            Console.WriteLine("{0} {1}", vnev, knev);
        }

        private static void feladat1()
        {
            Console.WriteLine("\n1.Feladat\n");
            Console.WriteLine("Kothencz Martin");

         

            int szamszor = 35 * 2;
            int szam2szor = 47 * 2;

            int eredmeny = szamszor + szam2szor;

            Console.WriteLine("Az eredmény {0}", eredmeny);

            //Console.WriteLine("A két értéket megszorozva kettővel és összeadva, ennyit kapunk: {0}", (35*2) + (47*2));

        }
    }
}
