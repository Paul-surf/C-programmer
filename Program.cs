using System;

namespace Strings_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vælg en opgave mellem 1 og 7!");
            if(Console.ReadLine() == "1"){
                Opgave1();
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



    }
}
