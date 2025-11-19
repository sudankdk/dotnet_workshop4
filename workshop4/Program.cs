namespace workshop4;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Name = "aship Ram";
        s1.Age = 20;

        Student s2 = new Student();
        s2.Name = "bishal Sita";
        s2.Age = 19;

        Console.WriteLine("Student 1:");
        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
        Console.WriteLine("School: " + Student.SchoolName);
        
        Console.WriteLine("Student 2:");
        Console.WriteLine("Name: " + s2.Name);
        Console.WriteLine("Age: " + s2.Age);
        Console.WriteLine("School: " + Student.SchoolName);
    }
}