using System;
class Squareroot
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Squareroot of given number is  " + Math.Round(Math.Sqrt(a),2));
        //Rounding off the answer to 2 decimals
    }
}