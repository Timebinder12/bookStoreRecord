using System;

public record Bookstore(int ID, string Title, string Author, double Price);

class Program
{
    static void Main(string[] args)
    {
        Bookstore book1 = new Bookstore(1, "Philosophers Stone", "J.K Rowling", 19.99);
        Bookstore book2 = new Bookstore(2, "Chamber of Secrets", "J.K Rowling", 19.99);
        Bookstore book3 = new Bookstore(3, "Prisoner of Azkaban", "J.K Rowling", 19.99);

        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);
    }
}