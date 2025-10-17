using BookManagement.Persistence;
using WebApplication1.Entitati;

public class UpdateBookHandler
{
    private readonly BookManagementContext _dbContext;
    public UpdateBookHandler(BookManagementContext dbContext) => _dbContext = dbContext;

    public async Task<IResult> Handle(int id, Book updated)
    {
        var book = await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == id);
        if (book == null) return Results.NotFound();

        book.Title = updated.Title;
        book.Author = updated.Author;
        book.Year = updated.Year;

        await _dbContext.SaveChangesAsync();
        return Results.Ok(book);
    }
}