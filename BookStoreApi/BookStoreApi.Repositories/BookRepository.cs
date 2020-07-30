using BookStoreApi.Data;
using BookStoreApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStoreApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;

        public BookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<HistoryBook> GetHistoryBooks()
        {
            return context.HistoryBooks.ToList();
        }
        public List<FantasyBook> GetFantasyBooks()
        {
            return context.FantasyBooks.ToList();
        }
        public List<ClassicBook> GetClassicBooks()
        {
            return context.ClassicBooks.ToList();
        }
    }
}
