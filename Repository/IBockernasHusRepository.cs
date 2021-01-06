using System.Collections.Generic;
using System.Threading.Tasks;
using BockernasHus.Models.Entities;

namespace Repository
{
  public interface IBockernasHusRepository
  {
        Task<IEnumerable<Book>> GetBooksAsync();

        Task<Book> GetBookAsync(int bookId);

        Task<Book> AddBookAsync(Book book);

        Task<Book> UpdateBookAsync(Book book);

        void DeleteBook(int bookId);

  }
}