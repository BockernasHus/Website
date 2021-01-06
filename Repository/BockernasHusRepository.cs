using System.Collections.Generic;
using System.Threading.Tasks;
using BockernasHus.Models.Entities;
using BockernasHus.Repository;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
  public class BockernasHusRepository : IBockernasHusRepository
  {
        private readonly BockernasHusDbContext _bockernasHusDbContext;

        public BockernasHusRepository(BockernasHusDbContext bockernasHusDbContext)
        {
            _bockernasHusDbContext = bockernasHusDbContext;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _bockernasHusDbContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookAsync(int bookId)
        {
            return await _bockernasHusDbContext.Books.FirstOrDefaultAsync(b => b.Id == bookId);
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            var result = await _bockernasHusDbContext.Books.AddAsync(book);
            await _bockernasHusDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            var result = await _bockernasHusDbContext.Books.FirstOrDefaultAsync(b => b.Id == book.Id);

            if (result != null)
            {
                result.Image = book.Image;
                result.NumberOfPages = book.NumberOfPages;
                result.Price = book.Price;
                result.Publisher = book.Publisher;
                result.PublishingYear = book.PublishingYear;
                result.Title = book.Title;
                result.Type = book.Type;
                result.Condition = book.Condition;
                result.Author = book.Author;
                result.Description = book.Description;

                await _bockernasHusDbContext.SaveChangesAsync();
            }
            return result;
        }

        public async void DeleteBook(int bookId)
        {
            var result = await _bockernasHusDbContext.Books.FirstOrDefaultAsync(b => b.Id == bookId);
            if (result != null)
            {
                _bockernasHusDbContext.Books.Remove(result);
                await _bockernasHusDbContext.SaveChangesAsync();
            }
        }
  }
}