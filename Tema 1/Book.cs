namespace Tema_1;


public record Book()
{
    public string? Title;
    public string?  Author;
    public int YearPublished;

    static string Metoda(object q)
    {
   
        if (q is Book a)
        {
            Console.WriteLine("Obiectul este de tip Book");
            Console.WriteLine(a.Title);
            Console.WriteLine(a.YearPublished);
        }
        else if (q is Borrower c)
        {
            Console.WriteLine("Obiectul este de tip Borrower");
            Console.WriteLine(c.Name);
            Console.WriteLine(c.BorrowdBooks.Count());
        }
        else 
            Console.WriteLine("Unknown type");

        return "";

    
    }
}
