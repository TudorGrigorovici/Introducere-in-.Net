using BookManagement.Persistence;


public class GetBooksPageHandler
{
    private readonly BookManagementContext _dbContext;

    public GetBooksPageHandler(BookManagementContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IResult> Handle(int page, int pageSize)
    {
        // Validare simplă
        if (page <= 0 || pageSize <= 0)
            return Results.BadRequest("Page and pageSize must be greater than 0.");

        var books = await _dbContext.Books
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return Results.Ok(books);
    }
}
