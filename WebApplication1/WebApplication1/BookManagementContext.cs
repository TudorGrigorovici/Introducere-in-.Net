﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Entitati;

namespace BookManagement.Persistence;

public class BookManagementContext : DbContext
{
    public BookManagementContext(DbContextOptions<BookManagementContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}
