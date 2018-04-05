using System;

namespace Arya
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOne;
            int num;
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
                string loop, pool;
                int cool, man;
                Console.Write("Choose number of 0 to 10: ");
                loop = Console.ReadLine();
                Console.Write("Choose number of 90 to 100: ");
                pool = Console.ReadLine();
                cool = Convert.ToInt32(loop);
                man = Convert.ToInt32(pool);
                if (cool == 0 || cool == 1 || cool == 2 || cool == 3 || cool == 4 || cool == 5 || cool == 6 || cool == 7 ||
                cool == 8 || cool == 9 || cool == 10 || man == 90 || man == 91 || man == 92 || man == 93 || man == 94 ||
                man == 95 || man == 96 || man == 97 || man == 98 || man == 99 || man == 10)
                {
                    for (int i = cool; i < man; i += 1)
                    {
                        Console.WriteLine("Number: " + i);
                    }
                }
                else if (cool != 0 || cool != 1 || cool != 2 || cool != 3 || cool != 4 || cool != 5 || cool != 6 || cool != 7
                 || cool != 8 || cool != 9 || cool != 10 || man != 90 || man != 91 || man != 92 || man != 93 || man != 94 || man != 95 || man != 96 || man != 97 || man != 98 || man != 99 || man != 100)
                {
                    Console.WriteLine("Pealese add true numbers ...");

                    Console.Write("Choose number of 0 to 10: ");
                    loop = Console.ReadLine();
                    Console.Write("Choose number of 90 to 100: ");
                    pool = Console.ReadLine();
                    cool = Convert.ToInt32(loop);
                    man = Convert.ToInt32(pool);
                    if (cool == 0 || cool == 1 || cool == 2 || cool == 3 || cool == 4 || cool == 5 || cool == 6 || cool == 7 ||
                    cool == 8 || cool == 9 || cool == 10 || man == 90 || man == 91 || man == 92 || man == 93 || man == 94 ||
                    man == 95 || man == 96 || man == 97 || man == 98 || man == 99 || man == 10)
                    {
                        for (int i = cool; i < man; i += 1)
                        {
                            Console.WriteLine("Number: " + i);
                        }
                    }
                }
                else if (loop == "a" || loop == "b" || loop == "c" || loop == "d" || loop == "e" || loop == "f" || loop == "g" || loop == "h" || loop == "i" || loop == "j" || loop == "k" || loop == "l" || loop == "m" || loop == "n" || loop == "o" || loop == "p" || loop == "q" || loop == "r" || loop == "s" || loop == "t" || loop == "u" || loop == "v" || loop == "w" || loop == "x" || loop == "y" || loop == "z" ||
                pool == "a" || pool == "b" || pool == "c" || pool == "d" || pool == "e" || pool == "f" || pool == "g" || pool == "h" || pool == "i" || pool == "j" || pool == "k" || pool == "l" || pool == "m" || pool == "n" || pool == "o" || pool == "p" || pool == "q" || pool == "r" || pool == "s" || pool == "t" || pool == "u" || pool == "v" || pool == "w" || pool == "x" || pool == "y" || pool == "z")
                {
                    Console.WriteLine("Pealese choose number.....");

                    Console.Write("Choose number of 0 to 10: ");
                    loop = Console.ReadLine();
                    Console.Write("Choose number of 90 to 100: ");
                    pool = Console.ReadLine();
                    cool = Convert.ToInt32(loop);
                    man = Convert.ToInt32(pool);
                    if (cool == 0 || cool == 1 || cool == 2 || cool == 3 || cool == 4 || cool == 5 || cool == 6 || cool == 7 ||
                    cool == 8 || cool == 9 || cool == 10 || man == 90 || man == 91 || man == 92 || man == 93 || man == 94 ||
                    man == 95 || man == 96 || man == 97 || man == 98 || man == 99 || man == 10)
                    {
                        for (int i = cool; i < man; i += 1)
                        {
                            Console.WriteLine("Number: " + i);
                        }
                    }
                }
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
                string loop = "";
                while (loop != "******************************")
                {
                    loop += "*";
                    Console.WriteLine(loop);

                }

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
