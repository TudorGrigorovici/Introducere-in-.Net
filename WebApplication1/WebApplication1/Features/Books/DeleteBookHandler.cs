using BookManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entitati;
using WebApplication1.BookManagementContext.cs;

namespace WebApplication1.Features.Books;

public class DeleteBookHandler
{
    private readonly BookManagementContext _dbContext;

    public DeleteBookHandler(BookManagementContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IResult> Handle(int bookId)
    {
        var book = await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == bookId);
        if (book == null)
        {
            return Results.NotFound();
        }

        _dbContext.Books.Remove(book);
        var saveChangesAsync = await _dbContext.SaveChangesAsync();
        return Results.NoContent();
    }
}