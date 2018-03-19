using System;

namespace Arya
{
    class Program
    {
        static void Main(string[] args)
        {
            // In hamoone
            string numberOne;
            int num;
            // this function show you all the messages. make your Main clean.
            ShowMessage();
            numberOne = Console.ReadLine();
            num = Convert.ToInt32(numberOne);
            if (num == 1)
            {
                for (int i = 1; i < 101; ++i)
                {
                    Console.WriteLine("Number: " + i);
                }
            }
            else if (num == 2)
            {
                for (int i = 1; i < 101; i += 2)
                {
                    Console.WriteLine("Number: " + i);
                }
                // i inja tamom mishe
            }
            else if (num == 3)
            {
                for (int i = 0; i < 101; i += 2)
                {
                    Console.WriteLine("Number: " + i);
                }
            }
            else if (num == 4)
            {

            }
            else if (num == 5)
            {

            }
            else if (num == 6)
            {
                string alfa = "";
                while (alfa != "**********")
                {
                    alfa += "*";
                    Console.WriteLine(alfa);
                }
            }
            else if (num == 7)
            {
                
            }
            else if (num == 0)
            {
                System.Environment.Exit(0);
            }
        }

        public static void ShowMessage()
        {
            Console.WriteLine("Wellcome");
            Console.WriteLine("Please choose number from 1 to 7 and if you want to exit click 0 ");
            Console.WriteLine("Numbers labour :");
            Console.WriteLine("Number 1 : Numbers 1 to 100");
            Console.WriteLine("Number 2 : Odd numbers of 1 to 100");
            Console.WriteLine("Number 3 : Even numbers of 1 to 100");
            Console.WriteLine("Number 4 : Interval two numbrs between 1 to 100");
            Console.WriteLine("Number 5 : It's the last number task but with other programming");
            Console.WriteLine("Number 6 : Star triangle");
            Console.WriteLine("Number 7 : Bigger Star triangle");
            Console.WriteLine("Number 0 : Exit");
            Console.Write("Choose number: ");
        }
    }
}
