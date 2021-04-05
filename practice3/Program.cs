using System;

namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start of Sale
            Console.WriteLine("Welcome to the Grand Circus Store");
            Console.WriteLine("What item would you like to buy? ");
            string itemName = Console.ReadLine();

            //Get Quanity
            Console.WriteLine($"How may {itemName} would you like to buy?");
            double quanity = double.Parse(Console.ReadLine());

            //Get Price
            Console.WriteLine("What is the price listed on the price tag?" );
            string price = Console.ReadLine();
            double priceP = double.Parse(price);

            //Calculations
            const double salesTax = 1.06;
            double totalCost = Math.Round((priceP * quanity) * salesTax,2);


            //Display info
            Console.WriteLine($"Ok, so you wanted to purchase {itemName} for {priceP} ");
            Console.WriteLine($"After sales tax, your total is {totalCost}.");

            //Get Cash
            Console.Write("How much cash would you like to pay with ");
            double cashIn = double.Parse(Console.ReadLine());

            //Get Change
            double change = Math.Round(cashIn - totalCost,2);

            //Display Change
            Console.WriteLine($"Your change is {change}");
            Console.WriteLine("Thank you for shoppig at Grand Circus! ");

            //Student Discount Day
            Console.Write("Good news! It's student discount day!");
            totalCost = Math.Round(totalCost * .9,2);
            Console.WriteLine($"Your new total is: {totalCost}");

            //Get Change
            change = Math.Round(cashIn - totalCost, 2);

            //Display Change
            Console.WriteLine($"Your change is {change}");

            Console.ReadLine();
        }
    }
}

//at store, give price give back total