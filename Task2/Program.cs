namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(1, 2));
        Console.WriteLine(calc.Multiply(2, 3));
        calc.PrintWelcome();
    }
}