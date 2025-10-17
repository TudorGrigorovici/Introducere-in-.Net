using System;

namespace BookManagement.Exceptions;

public class BookNotFoundException : Exception
{
    public BookNotFoundException(int id)
        : base($"Book with ID {id} was not found.") { }
}