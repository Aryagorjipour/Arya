using System;

namespace Arya
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runApp = true;
            while (runApp)
            {
                ShowMessage();
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    ContinuousNumbers();
                }
                else if (option == 2)
                {
                    OddNumbers();
                }
                else if (option == 3)
                {
                    EvenNumbers();
                }
                else if (option == 4)
                {
                    bool currectChoice = false;
                    int givenNumber1 = 0, givenNumber2 = 0;
                    while (!currectChoice)
                    {
                        Console.Write("Choose number of 0 to 10: ");
                        givenNumber1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Choose number of 90 to 100: ");
                        givenNumber2 = Convert.ToInt32(Console.ReadLine());

                        if ((givenNumber1 >= 0 && givenNumber1 < 10) && (givenNumber2 >= 90 && givenNumber2 < 100))
                        {
                            currectChoice = true;
                        }
                        else
                        {
                            Console.WriteLine("You entered a wrong number.");
                        }
                    }
                    for (int i = givenNumber1; i < givenNumber2; i += 1)
                    {
                        Console.WriteLine("Number: " + i);
                    }
                }

                else if (option == 5)
                {
                    int givenNumber1 = 0, givenNumber2 = 0;
                    Console.Write("Choose the first number: ");
                    givenNumber1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose the second number: ");
                    givenNumber2 = Convert.ToInt32(Console.ReadLine());
                    while (givenNumber1 != givenNumber2)
                    {
                        Console.WriteLine("Number: " + givenNumber1++);
                    }

                }
                else if (option == 6)
                {
                    string row = "";
                    while (row != "**********")
                    {
                        row += "*";
                        Console.WriteLine(row);
                    }
                }
                else if (option == 7)
                {
                    string row = "";
                    while (row != "*******")
                    {
                        row += "*";
                        Console.WriteLine(row);
                    }

                    while (row != "*")
                    {
                        row = row.Substring(1);
                        Console.WriteLine(row);
                    }
                }
                else if (option == 0)
                {
                    runApp = false;
                    System.Environment.Exit(0);
                }
            }
        }

        public static void ContinuousNumbers()
        {
            for (int i = 1; i < 101; ++i)
            {
                Console.WriteLine("Number: " + i);
            }
        }

        public static void OddNumbers()
        {
            for (int i = 1; i < 101; i += 2)
            {
                Console.WriteLine("Number: " + i);
            }
        }

        public static void EvenNumbers()
        {
            for (int i = 0; i < 101; i += 2)
            {
                Console.WriteLine("Number: " + i);
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
