namespace Task2;

public class Calculator
{
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the calculator!");
    }

    public int Add(int x, int y)
    {
        return x + y;
    }
    
    public int Multiply(int x, int y=1)
    {
        return x * y;
    }
}