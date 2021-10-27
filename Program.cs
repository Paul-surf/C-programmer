using System;

namespace Strings_C_
{
    class Program
    {

        static int GoBackWrongCount = 0;
        static int ChooseTaskWrongCount = 0;
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;
            ChooseTask();
        }

        static void ChooseTask() {
            Console.Clear();
            GoBackWrongCount = 0;
            TypeWrite("Choose a task between 1 and 7!");

            string ChosenTask = Console.ReadLine();

            if(ChosenTask == "1"){
                Task1();
            } else
            if (ChosenTask == "2") {
                Task2();
            } else
            if (ChosenTask == "3") {
                Task3();
            } else
            if (ChosenTask == "4") {
                Task4();
            } else
            if (ChosenTask == "5") {
                Task5();
            } else
            if (ChosenTask == "6") {
                Task6();
            } else 
            if (ChosenTask == "7") {
                Task7();
            } else {
                Console.Clear();
                ChooseTaskWrongCount++;
                if(ChooseTaskWrongCount > 2) {
                    TypeWrite("You have used the maximum amount of tries!");
                    System.Threading.Thread.Sleep(1000);
                    TypeWrite("Shutting down...");
                    System.Threading.Thread.Sleep(1000);
                    System.Environment.Exit(0);
                } else {
                    TypeWrite("Write a number between 1 and 7!" + " ({0} Tries left!)", (3-ChooseTaskWrongCount));
                    System.Threading.Thread.Sleep(2000);
                    ChooseTask();
                }
            }
        }
        static void Task1() {
            Console.Clear();
            TypeWrite("Write a sentence and I will tell you, where the first space is!");
            string GivenString = Console.ReadLine();
            if(GivenString.IndexOf(" ", 0) == -1) {
                TypeWrite("There aren't any spaces in your sentence!");
                Retry();
            } else {
                int place = GivenString.IndexOf(" ", 0) + 1;
                TypeWrite("The first space is on space: {0}!", place);    
                Retry();       
            }
        }

        static void Task2() {
            Console.Clear();
            TypeWrite("Skriv en sætning og jeg vil fjerne alt før det første mellemrum!");
            TypeWrite("Write a sentence and I will delete everything before it!");
            string GivenString = Console.ReadLine();
            TypeWrite(GivenString.Substring(GivenString.IndexOf(" ", 0) + 1));
            Retry();
        }

        static void Task3() {
            Console.Clear();
            TypeWrite("Skriv en sætning og jeg vil fortælle dig, hvor mange mellemrum der er!");
            int count = 0;
            string GivenString = Console.ReadLine();
            char[] ch = GivenString.ToCharArray();
            foreach(char i in ch) {
                if(i.ToString() == " ") {
                    count++;
                }
            }
            if(count > 0) {
                TypeWrite("Der er " + count + " mellemrum i sætningen!");
            } else {
                TypeWrite("Der er ingen mellemrum i sætningen!");
            }
            Retry();
        }

        static void Task4() {
            Console.Clear();
            TypeWrite("Skriv en sætning med ordet 'måske' og jeg vil fjerne det første 'måske' jeg støder på");
            string GivenString = Console.ReadLine();
            if(GivenString.ToUpper() != "MÅSKE" && GivenString.Split(" ").Length == 1) {
                TypeWrite(GivenString.Split(" ")[0]);
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
                
                TypeWrite(string.Join(" ", arr));
            }
            Retry();
        }

        static void Task5() {
            Console.Clear();
            TypeWrite("Skriv en sætning med ordet 'måske' og jeg vil fjerne dem");
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
            TypeWrite(string.Join(" ", arr));
            Retry();
        }

        static void Task6() {
            Console.Clear(); 
            string GivenString, ReverseString = string.Empty;  
            Console.Write("Skriv et ord, så tjekker jeg om det er en palindrome!");
            TypeWrite("");  
            GivenString = Console.ReadLine();  
            if (GivenString != null) {
                for (int i = GivenString.Length - 1; i >= 0; i--)  {  
                    ReverseString += GivenString[i].ToString();  
                }
                if (ReverseString == GivenString) {  
                    TypeWrite("Ja, " + GivenString + " er palindrome");  
                } else {  
                    TypeWrite("Nej, " + GivenString + " er ikke palindrome");  
                }  
            }  
            Retry();
        }

        static void Task7() {
            Console.Clear();
            TypeWrite("Skriv en sætning og jeg vil tjekke om den er palindrome! (Jeg ser bort fra mellemrum og special tegn)");
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
                TypeWrite("The given text is Palindrome!");
            } else {
                TypeWrite("The given string is NOT Palindrome!");
            }
            Retry();
        }

        static void Retry() {
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            TypeWrite("Gå Tilbage?");
            TypeWriteSingle("Ja/Nej: ");
            string GivenString = "";
            while(GivenString != "JA" && GivenString != "NEJ") {
                GivenString = Console.ReadLine().ToUpper();
                if(GivenString == "JA") {
                    ChooseTaskWrongCount = 0;
                    ChooseTask();
                } else if(GivenString == "NEJ"){
                    Console.Clear();
                    TypeWrite("Shutting down...");
                    System.Threading.Thread.Sleep(1000);
                    System.Environment.Exit(0);
                } else {
                    Console.Clear();
                    if(GoBackWrongCount == 2) {
                        TypeWrite("Du har nået de maksimale forsøg!");
                        System.Threading.Thread.Sleep(1000);
                        TypeWrite("Shutting down...");
                        System.Threading.Thread.Sleep(1000);
                        System.Environment.Exit(0);
                    } else {
                        GoBackWrongCount++;
                        TypeWrite("Svar enten Ja eller Nej! " + "({0} forsøg tilbage)", (3-GoBackWrongCount));
                        System.Threading.Thread.Sleep(1000);
                        Retry();
                    }
                }
            }
        }

        static void TypeWriteSingle(string GivenString) {
            for(int i = 0; i < GivenString.Length; i++) {
                Console.Write(GivenString[i]);
                System.Threading.Thread.Sleep(40);
            }
        }
        static void TypeWrite(string GivenString) {
            for(int i = 0; i < GivenString.Length; i++) {
                Console.Write(GivenString[i]);
                System.Threading.Thread.Sleep(40);
            }
            Console.WriteLine();
        }
        static void TypeWrite(string GivenString, int GivenInt) {
            GivenString = GivenString.Replace("{0}", GivenInt.ToString());
            for(int i = 0; i < GivenString.Length; i++) {
                Console.Write(GivenString[i]);
                System.Threading.Thread.Sleep(35);
            }
            Console.WriteLine();
        }

    }
}
