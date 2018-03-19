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
                // it should be in a function !!!
                for (int i = 1; i < 101; ++i)
                {
                    Console.WriteLine("Number: " + i);
                }
            }
            else if (num == 2)
            {
                // inja adade zoj ro neshon mide ?
                // Na adade farde 
                // behtar bod injori mineweshti
                // for (int x = 1; x < 101; x += 2)
                // for (int x = 1; x < 101; ++x)
                // {
                //     // Console.WriteLine("Number: " + x);
                //     Console.WriteLine("Number: " + x++);
                // }
                // chon ke motaghayere i ro beine {} minevisi biron az {} ham mitoni baz tarifesh koni
                for (int i = 1; i < 101; i += 2)
                {
                    Console.WriteLine("Number: " + i);
                }
                // i inja tamom mishe
            }
            else if (num == 3)
            {
                // for (int p = 1; p < 101; ++p)
                // {
                //     Console.WriteLine("Number: " + ++p);
                // }
                for (int i = 0; i < 101; i += 2)
                {
                    Console.WriteLine("Number: " + i);
                }
                // khob alan moshkel chie ?

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
                // inja age space ro bar darim drost mishe ?
                // Cool ;)
                // rasti dar bare dokme exit hamaro dakhel while benevisam ?
                while (alfa != "**********")
                {
                    alfa += "*";
                    Console.WriteLine(alfa);
                }
            }
            else if (num == 0)
            {

                // it should work
                // Make a document about System and System.Environment !!!
                // and email it for me
                //I am sorry but it code return ???
                // use all of the in the functions like i write now
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
