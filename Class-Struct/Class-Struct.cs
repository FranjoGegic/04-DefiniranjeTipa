﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*namespace Vsite.CSharp
{
    // TODO: Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public

        class MojaKlasa
        {

            //  Dodati privatno polje (podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
            public int broj = 5;

            //  U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "broj".
            public void IspišiČlan()
            {
                Console.WriteLine(broj);
            }
        }
  

    // TODO: Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
    struct MojaStruktura
    {
        //  Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        public string tekst; // = "MojaStruktura";

        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }
        //  U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);

        }

    public class ClassStruct
    {
        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
                // TODO: Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
                Console.WriteLine(mk1.broj);
                Console.WriteLine(mk2.broj);


                Console.WriteLine();
            // TODO: Otkomentirati donju naredbu.
            mk2.broj = 2;
                //  Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
                Console.WriteLine(mk1.broj);
                Console.WriteLine(mk2.broj);

            }

        public static void IspišiStrukture()
        {
            // TODO: Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura"
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
                // TODO: Pozvati metodu IspišiČlan za obje instance
                Console.WriteLine(ms1.tekst);
                Console.WriteLine(ms1.tekst);

                Console.WriteLine();
            // TODO: Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
                // TODO: Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
                Console.WriteLine(ms1.tekst);
                Console.WriteLine(ms1.tekst);

            }

        static void Main(string[] args)
        {
            IspišiKlase();

            Console.WriteLine();

            IspišiStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
*/