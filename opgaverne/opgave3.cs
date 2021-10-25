using System;

namespace opgave3
{
    class Program
    {
        public Program() {
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
                Console.WriteLine("Der er " + count + "mellemrum i sætningen!");
            } else {
                Console.WriteLine("Der er ingen mellemrum i sætningen!");
            }
            //KørIgen();
        }
    }
}