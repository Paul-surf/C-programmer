﻿using System;

namespace Strings_C_
{
    class Program
    {
        static void Main(string[] args) {
            VælgOpgave();
        }

        static void VælgOpgave() {
            Console.Clear();
            Console.WriteLine("Vælg en opgave mellem 1 og 7!");

            string ValgtOpgave = Console.ReadLine();

            if(ValgtOpgave == "1"){
                Opgave1();
            } 
            if (ValgtOpgave == "2") {
                Opgave2();
            }
            if (ValgtOpgave == "3") {
                Opgave3();
            }
        }
        static void Opgave1() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning og jeg vil fortælle dig, hvor det første mellemrum er!");
            string GivenString = Console.ReadLine();
            if(GivenString.IndexOf(" ", 0) == -1) {
                Console.WriteLine("Der er intet mellemrum i din sætning!");
                KørIgen();
            } else {
                int plads = GivenString.IndexOf(" ", 0) + 1;
                Console.WriteLine("Det første mellemrum er på plads: " + plads);    
                KørIgen();       
            }
        }

        static void Opgave2() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning og jeg vil fjerne alt før det første mellemrum!");
            string GivenString = Console.ReadLine();
            Console.WriteLine(GivenString.Substring(GivenString.IndexOf(" ", 0) + 1));
            KørIgen();
        }

        static void Opgave3() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning og jeg vil fortælle dig, hvor mange mellemrum der er!");
            int count = 0;
            string GivenString = Console.ReadLine();
            char[] ch = GivenString.ToCharArray();
            foreach(char i in ch) {
                if(i.ToString() == " ") {
                    count++;
                }
            }
            if(count > 0) {
                Console.WriteLine("Der er " + count + " mellemrum i sætningen!");
            } else {
                Console.WriteLine("Der er ingen mellemrum i sætningen!");
            }
            KørIgen();
        }

        static void KørIgen() {
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Gå Tilbage?");
            Console.Write("Ja/Nej: ");
            string GivenString = Console.ReadLine().ToUpper();
            if(GivenString == "JA") {
                VælgOpgave();
            }
        }

    }
}
