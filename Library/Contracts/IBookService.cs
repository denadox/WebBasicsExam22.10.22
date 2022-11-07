using Library.Data.Models;
using Library.Models;

namespace Library.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<BookViewModel>> GetAllAsync();

        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task AddBookAsync(AddBookViewModel model);

        Task AddBookToCollectionAsync(int bookId, string applicationUserId);

        Task<IEnumerable<BookViewModel>> GetReadAsync(string applicationUserId);

        Task RemoveBookFromCollectionAsync(int bookId, string applicationUserId);
    }
}
