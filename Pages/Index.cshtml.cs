using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BockernasHus.Models.Entities;
using BockernasHus.Repository;

namespace BockernasHus.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BockernasHus.Repository.BockernasHusDbContext _context;

        public IndexModel(BockernasHus.Repository.BockernasHusDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
