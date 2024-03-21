namespace Mission11_Ward.Models.ViewModels;

public class BooksListViewModel
{
    public IQueryable<Book> Books { get; set; }

    public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
}