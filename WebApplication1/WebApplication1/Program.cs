using BookManagement.Persistence;
using WebApplication1.Persistence;
using WebApplication1.Features.Books;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entitati;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BookManagementContext>(options =>
    options.UseInMemoryDatabase("BooksDb"));

builder.Services.AddScoped<CreateBookHandler>();
builder.Services.AddScoped<DeleteBookHandler>();
builder.Services.AddScoped<UpdateBookHandler>();
builder.Services.AddScoped<FilterBooksHandler>();
builder.Services.AddScoped<SortBooksHandler>();

var app = builder.Build();


app.MapPost("/books", async (Book book, CreateBookHandler handler) =>
    await handler.Handle(book));

app.MapDelete("/books/{id:int}", async (int id, DeleteBookHandler handler) =>
    await handler.Handle(id));

app.MapPut("/books/{id:int}", async (int id, Book book, UpdateBookHandler handler) =>
    await handler.Handle(id, book));

app.MapGet("/books/filter", async (string author, FilterBooksHandler handler) =>
    await handler.Handle(author));

app.MapGet("/books/sort", async (string by, SortBooksHandler handler) =>
    await handler.Handle(by));

app.Run();