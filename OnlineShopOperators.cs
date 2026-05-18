using System;

namespace RealTimeUseCase
{
    class OnlineShoppingCart
    {
        static void Main(string[] args)
        {
            string productName = "Laptop";
            double productPrice = 55000;
            int quantity = 2;

            // Arithmetic Operator
            double totalAmount = productPrice * quantity;

            // Discount Logic using Relational + Logical Operators
            bool isPremiumCustomer = true;

            if (totalAmount > 100000 && isPremiumCustomer)
            {
                totalAmount -= 10000;
            }

            // Ternary Operator
            string deliveryCharge =
                (totalAmount > 50000) ? "Free Delivery" : "Delivery Charges Applied";

            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product Price: " + productPrice);
            Console.WriteLine("Quantity: " + quantity);

            Console.WriteLine("Final Amount: " + totalAmount);

            Console.WriteLine(deliveryCharge);

            // Increment Operator
            quantity++;

            Console.WriteLine("Updated Quantity: " + quantity);

            Console.ReadLine();
        }
    }
}