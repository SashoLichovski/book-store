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
    }
}
