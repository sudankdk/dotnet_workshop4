namespace task3;

public class ParameterDemo
{
    public int Increase(ref int number)
    {
        number += 10;
        return number;
    }

    public void GetFullName(out string fullName)
    {
        fullName = "JamesBond";
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}