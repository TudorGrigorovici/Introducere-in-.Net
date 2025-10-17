using BookManagement.Persistence;

namespace WebApplication1.Features.Books;
using WebApplication1.Entitati;
public class SortBooksHandler
{
    private readonly BookManagementContext _dbContext;
    public SortBooksHandler(BookManagementContext dbContext) => _dbContext = dbContext;

    public async Task<IResult> Handle(string sortBy)
    {
        var query = _dbContext.Books;

        query = sortBy.ToLower() switch
        {
            "title" => query.OrderBy(b => b.Title),
            "year" => query.OrderBy(b => b.Year),
            _ => query
        };

        var books = await query.ToListAsync();
        return Results.Ok(books);
    }
}