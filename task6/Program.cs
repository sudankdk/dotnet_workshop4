namespace task6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter marks:");
        double marks;
        while (!double.TryParse(Console.ReadLine(), out marks))
        {
            Console.WriteLine("Invalid input! Please enter a number for marks:");
        }

        Console.WriteLine("Enter total:");
        double total;
        while (!double.TryParse(Console.ReadLine(), out total) || total == 0)
        {
            Console.WriteLine("Invalid input! Please enter a non-zero number for total:");
        }

        double percentage = marks / total * 100;
        Console.WriteLine($"Percentage: {percentage}%");
    }
}