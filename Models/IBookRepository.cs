namespace Mission11_Ward.Models;

public interface IBookRepository
{
    public IQueryable<Book> Books { get; }
}