using System;
namespace Uppgift_5_A5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();

            string[] svar = {"Ja","Nej","Kanske","Typ","Ibland","Sisådar 400","Ja, men faktiskt nej","Varför frågar du mig det?!","Gå hem","Jadu" };

            while (true) 
            {
                Console.WriteLine("Ställ en fråga eller \"a\" om du vill avsluta");

                if (Console.ReadLine().ToLower() == "a")
                {
                    break;
                }

                Console.WriteLine(svar[slump.Next(0,11)]);
            }
        }
    }
}