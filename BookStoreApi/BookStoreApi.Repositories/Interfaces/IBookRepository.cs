using BookStoreApi.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApi.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<HistoryBook> GetHistoryBooks();
        List<FantasyBook> GetFantasyBooks();
        List<ClassicBook> GetClassicBooks();
        void Delete(int bookId, string bookType);
        ClassicBook GetClassicById(int id);
        FantasyBook GetFantasyById(int id);
        HistoryBook GetHistoryById(int id);
        void UpdateClassicBook(ClassicBook dbBook);
        void UpdateFantasyBook(FantasyBook dbBook);
        void UpdateHistoryBook(HistoryBook dbBook);
        void AddHistory(HistoryBook newBook);
        void AddClassic(ClassicBook newBook);
        void AddFantasy(FantasyBook newBook);
    }
}
