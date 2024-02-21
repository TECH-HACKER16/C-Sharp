using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("1->Addition\n2->Subtraction\n3->Multiplication\n4->Division ");
        Console.Write("\nEnter ur choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("\nEnter first number ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second number ");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("\nSum of given two numbers is  " + sum);
            break;
            case 2:
                Console.Write("\nEnter first number ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter Second number ");
                int d = Convert.ToInt32(Console.ReadLine());
                int diff = c - d;
                Console.WriteLine("\nDifference of given two numbers is  " + diff);
            break;
            case 3:
                Console.Write("\nEnter first number ");
                int e = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter Second number ");
                int f = Convert.ToInt32(Console.ReadLine());
                int product = e * f;
                Console.WriteLine("\nProduct of given two numbers is  " + product);
            break;
            case 4:
                Console.Write("\nEnter Dividend ");
                float g = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter Divisor ");
                float h = Convert.ToInt32(Console.ReadLine());
                float result = g / h;
                float rem = Convert.ToInt32(g % h);
                float result1 = Convert.ToInt32(g/h);
                Console.WriteLine("\nResult of given two numbers is  " + Math.Round(result, 2));
                Console.WriteLine("\n OR \n");
                Console.WriteLine("Result of given two numbers is  " + result1 +" & Remainder is "+rem);
            break;
            default:
                Console.WriteLine("Invalid choice");
            break;
        }
    }
}
