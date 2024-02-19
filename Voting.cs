using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());           
            if (age > 18)
            {
                Console.WriteLine("Your r eligible to vote");
            }
            else
            {
                Console.WriteLine("You r not eligible to vote");
            }
        }
    }