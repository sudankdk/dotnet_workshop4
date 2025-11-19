namespace task3;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();
        int value = 5;
        Console.WriteLine($" value: {value}");
        int increasedValue = demo.Increase(ref value);
        Console.WriteLine($"increased value: {increasedValue}");


        demo.GetFullName(out string fullName);
        Console.WriteLine("Full Name is : " + fullName);

        int sum = demo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine(sum);
    }
}