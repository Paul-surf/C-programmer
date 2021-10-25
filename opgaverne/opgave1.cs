using System;

namespace opgave1
{
    class Program
    {
        public Program() {
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