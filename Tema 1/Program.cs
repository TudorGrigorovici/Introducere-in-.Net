// See https://aka.ms/new-console-template for more information
using Tema_1;


List<Book> lista = new List<Book>();
Console.WriteLine("Enter a Book name: ");
Console.WriteLine("");
while (true)
{
    var  bookTitle = Console.ReadLine();
    if (bookTitle == "stop")
    {
        break;
    }

    var book = new Book{YearPublished = 12,Title=bookTitle};
    if (bookTitle != null) lista.Add(book);
}

foreach (var s1 in lista)
{
    Console.WriteLine(s1.Title);
}
List<Book> list2 = new()
{
    new Book {Title="Book 1", YearPublished = 2001 },
    new Book {Title="Book 2", YearPublished = 2015},
    new Book {Title="Book 3", YearPublished = 1940 },
    new Book {Title="Book 4", YearPublished = 1930 },
    new Book {Title="Book 5", YearPublished = 2030 }
};

var filtered = list2.Where(static c => c.YearPublished >= 2010);
foreach (var c in filtered)
{
    Console.WriteLine(c.Title);
}