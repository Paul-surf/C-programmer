using System;

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
        }
        static void Opgave1() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning og jeg vil fortælle dig, hvor det første mellemrum er!");
            string GivenString = Console.ReadLine();
            if(GivenString.IndexOf(" ", 0) == -1) {
                Console.WriteLine("Der er intet mellemrum i din sætning!");
                Console.ReadLine();
            } else {
                int plads = GivenString.IndexOf(" ", 0) + 1;
                Console.WriteLine("Det første mellemrum er på plads: " + plads);    
                Console.ReadLine();        
            }
        }

        static void Opgave2() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning og jeg vil fjerne alt før det første mellemrum!");
            string GivenString = Console.ReadLine();
            Console.WriteLine(GivenString.Substring(GivenString.IndexOf(" ", 0) + 1));
            Console.ReadLine();
        }

        static void KørIgen() {
            string GivenString = Console.ReadLine().ToUpper();
            if(GivenString == "JA") {
                VælgOpgave();
            }
        }

    }
}
