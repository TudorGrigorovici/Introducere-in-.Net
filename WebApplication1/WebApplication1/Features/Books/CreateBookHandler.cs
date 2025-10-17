using BookManagement.Persistence;
using WebApplication1.Entitati;

public class CreateBookHandler
{
    private readonly BookManagementContext _dbContext;
    public CreateBookHandler(BookManagementContext dbContext) => _dbContext = dbContext;

    public async Task<IResult> Handle(Book book)
    {
        _dbContext.Books.Add(book);
        return Results.Created($"/books/{book.Id}", book);
    }
}