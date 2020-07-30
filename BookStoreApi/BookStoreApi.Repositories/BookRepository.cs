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

        public void Delete(int bookId, string bookType)
        {
            // I know it's not the a good way to do it like this, but for the sake of time...
            if (bookType == "History")
            {
                var historyBook = context.HistoryBooks.FirstOrDefault(x => x.Id == bookId);
                context.HistoryBooks.Remove(historyBook);
            }
            else if (bookType == "Fantasy")
            {
                var fantasyBook = context.FantasyBooks.FirstOrDefault(x => x.Id == bookId);
                context.FantasyBooks.Remove(fantasyBook);
            }
            else if (bookType == "Classic")
            {
                var classicBook = context.ClassicBooks.FirstOrDefault(x => x.Id == bookId);
                context.ClassicBooks.Remove(classicBook);
            }
            context.SaveChanges();
        }

        public ClassicBook GetClassicById(int id)
        {
            return context.ClassicBooks.FirstOrDefault(x => x.Id.Equals(id));
        }

        public FantasyBook GetFantasyById(int id)
        {
            return context.FantasyBooks.FirstOrDefault(x => x.Id.Equals(id));

        }

        public HistoryBook GetHistoryById(int id)
        {
            return context.HistoryBooks.FirstOrDefault(x => x.Id.Equals(id));

        }

        public void UpdateClassicBook(ClassicBook dbBook)
        {
            context.ClassicBooks.Update(dbBook);
            context.SaveChanges();
        }

        public void UpdateFantasyBook(FantasyBook dbBook)
        {
            context.FantasyBooks.Update(dbBook);
            context.SaveChanges();
        }

        public void UpdateHistoryBook(HistoryBook dbBook)
        {
            context.HistoryBooks.Update(dbBook);
            context.SaveChanges();
        }

        public void AddHistory(HistoryBook newBook)
        {
            context.HistoryBooks.Add(newBook);
            context.SaveChanges();
        }

        public void AddClassic(ClassicBook newBook)
        {
            context.ClassicBooks.Add(newBook);
            context.SaveChanges();
        }

        public void AddFantasy(FantasyBook newBook)
        {
            context.FantasyBooks.Add(newBook);
            context.SaveChanges();
        }
    }
}
