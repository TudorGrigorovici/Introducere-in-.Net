
using BookManagement.Persistence;

namespace BookManagement.Features.Books;

public class GetBooksHandler
{
    private readonly BookManagementContext _dbContext;

    public GetBooksHandler(BookManagementContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IResult> Handle()
    {
        var books = await _dbContext.Books.ToListAsync();
        return Results.Ok(books);
    }
}