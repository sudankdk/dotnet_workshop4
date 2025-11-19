namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine().Trim().ToLower();

        Daytype dayType;
        if (day == "sunday" || day == "saturday")
        {
            dayType = Daytype.Weekend;
        }
        else
        {
            dayType = Daytype.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");
        
        
        Book book1 = new Book("mero kitab", "ocd", 69.00);
        Book book2 = book1 with { title = "Thor", price = 1500.00 };

        Console.WriteLine("\nFirst Book:");
        Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");
        var (title, author, price) = book2;

        Console.WriteLine("\ndosro kitab |Decontructed:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");


    }
}