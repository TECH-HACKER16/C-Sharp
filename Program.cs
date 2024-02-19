class Addition
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second number ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("Sum of given two numbers is  " + sum);
    }
}