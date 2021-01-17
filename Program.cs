using System;

namespace VendingMashineTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            double budget = 0;

            while (inputLine != "Start")
            {
                double currCoin = double.Parse(inputLine);
                if (currCoin == 0.1 || currCoin == 0.2 || currCoin == 0.5 ||
                    currCoin == 1 || currCoin == 2)
                {
                    budget += currCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currCoin}");
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                double productPrice = 0;

                if (inputLine == "Nuts")
                {
                    productPrice = 2.0;
                }
                else if (inputLine == "Water")
                {
                    productPrice = 0.7 ;
                }
                else if (inputLine == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (inputLine == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (inputLine == "Coke")
                {
                    productPrice = 1.0;
                }

                if (productPrice != 0)
                {
                    if(budget >= productPrice)
                    {
                        Console.WriteLine($"Purchased {inputLine.ToLower()}");
                        budget -= productPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Change: {budget:F2}");
        }
    }
}
