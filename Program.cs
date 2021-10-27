using System;

namespace Strings_C_
{
    class Program
    {

        static int GåTilbageWrongCount = 0;
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;
            VælgOpgave();
        }

        static void VælgOpgave() {
            Console.Clear();
            GåTilbageWrongCount = 0;
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
            if (ValgtOpgave == "4") {
                Opgave4();
            }
            if (ValgtOpgave == "5") {
                Opgave5();
            }
            if (ValgtOpgave == "6") {
                Opgave6();
            }
            if (ValgtOpgave == "7") {
                Opgave7();
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

        static void Opgave4() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning med ordet 'måske' og jeg vil fjerne det første 'måske' jeg støder på");
            string GivenString = Console.ReadLine();
            if(GivenString.ToUpper() != "MÅSKE" && GivenString.Split(" ").Length == 1) {
                Console.WriteLine(GivenString.Split(" ")[0]);
            } else {
                string[] arr = GivenString.Split(" ");
                bool maybe = false;

                for(int i = 0; i < arr.Length; i++) {
                    if(arr[i].ToUpper() == "MÅSKE") {
                        maybe = true;
                    }
                    if(maybe && i != arr.Length-1) {
                        arr[i] = arr[i+1];
                    } else if(i == arr.Length - 1) {
                        arr[i] = "";
                    }
                }
                
                Console.WriteLine(string.Join(" ", arr));
            }
            KørIgen();
        }

        static void Opgave5() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning med ordet 'måske' og jeg vil fjerne dem");
            string GivenString = Console.ReadLine();
            string[] arr = GivenString.Split(" ");
            int count = 0;


            for(int i = 0; i < arr.Length; i++) {
                if(arr[i].ToUpper() == "MÅSKE") {
                    count++;
                }
            }
            for(int l = 0; l < count; l++) {
                bool maybe = false;
                for(int i = 0; i < arr.Length; i++) {
                if(arr[i].ToUpper() == "MÅSKE") {
                    maybe = true;
                }
                if(maybe && i != arr.Length-1) {
                    arr[i] = arr[i+1];
                } else if(i == arr.Length - 1) {
                    arr[i] = "";
                }
            }
            }
            Console.WriteLine(string.Join(" ", arr));
            KørIgen();
        }

        static void Opgave6() {
            Console.Clear(); 
            string GivenString, ReverseString = string.Empty;  
            Console.Write("Skriv et ord, så tjekker jeg om det er en palindrome!");
            Console.WriteLine("");  
            GivenString = Console.ReadLine();  
            if (GivenString != null) {
                for (int i = GivenString.Length - 1; i >= 0; i--)  {  
                    ReverseString += GivenString[i].ToString();  
                }
                if (ReverseString == GivenString) {  
                    Console.WriteLine("Ja, '{0}' er en Palindrome", GivenString, ReverseString);  
                } else {  
                    Console.WriteLine("Nej, '{0}' er ikke en palindrome", GivenString, ReverseString);  
                }  
            }  
            KørIgen();
        }

        static void Opgave7() {
            Console.Clear();
            Console.WriteLine("Skriv en sætning og jeg vil tjekke om den er palindrome! (Jeg ser bort fra mellemrum og special tegn)");
            string GivenString = Console.ReadLine().ToUpper();
            string[] arr = GivenString.Split(" ");
            string arrString = string.Join("", arr);
            arrString = arrString.Replace(",", "").Replace(".", "").Replace("?", "").Replace("!", "").Replace("*", "").Replace("/", "").Replace("=", "");
            char[] TempArr = arrString.ToCharArray();
            char[] TempArr2 = new char[TempArr.Length];
            int TempCount = 0;
            for(int i = TempArr.Length-1; i >= 0; i--) {
                 TempArr2[TempCount] = TempArr[i];
                 TempCount++;
            }
            string ReversedString = string.Join("", TempArr2);
            if(arrString == ReversedString) {
                Console.WriteLine("The given text is Palindrome!");
            } else {
                Console.WriteLine("The given string is NOT Palindrome!");
            }
            KørIgen();
        }

        static void KørIgen() {
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Gå Tilbage?");
            Console.Write("Ja/Nej: ");
            string GivenString = "";
            while(GivenString != "JA" && GivenString != "NEJ") {
                GivenString = Console.ReadLine().ToUpper();
                if(GivenString == "JA") {
                    VælgOpgave();
                } else if(GivenString == "NEJ"){
                    Console.Clear();
                    Console.WriteLine("Shutting down...");
                    System.Threading.Thread.Sleep(1000);
                    System.Environment.Exit(0);
                } else {
                    Console.Clear();
                    if(GåTilbageWrongCount == 2) {
                        Console.WriteLine("Du har nået de maksimale forsøg!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Shutting down...");
                        System.Threading.Thread.Sleep(1000);
                        System.Environment.Exit(0);
                    } else {
                        GåTilbageWrongCount++;
                        Console.WriteLine("Svar enten Ja eller Nej! " + "(" + (3 - GåTilbageWrongCount) + " Forsøg tilbage)");
                        System.Threading.Thread.Sleep(1000);
                        KørIgen();
                    }
                }
            }
        }
    }
}
