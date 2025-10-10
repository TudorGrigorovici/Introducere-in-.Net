namespace Tema_1;

public record Borrower()
{
    public int Id { get; init; }
    public string? Name;
    public List<Book>? BorrowdBooks;

    static void Method()
    {
        var book = new Book { YearPublished = 32 };
        var bor = new Borrower { Name = "Borrower1" };
        var bo2 = bor with { BorrowdBooks = new List<Book> { book } };
    }
}

