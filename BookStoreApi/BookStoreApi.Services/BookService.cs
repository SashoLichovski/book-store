using BookStoreApi.Repositories.Interfaces;
using BookStoreApi.Services.Helpers;
using BookStoreApi.Services.Interfaces;
using BookStoreApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStoreApi.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        public BookViewModel GetAll()
        {
            var model = new BookViewModel();
            var dbHistoryBooks = bookRepo.GetHistoryBooks();
            var dbClassicBooks = bookRepo.GetClassicBooks();
            var dbFantasyBooks = bookRepo.GetFantasyBooks();

            model.HistoryBooks = dbHistoryBooks.Select(x => x.ToHistoryModel()).ToList();
            model.FantasyBooks = dbFantasyBooks.Select(x => x.ToFantasyModel()).ToList();
            model.ClassicBooks = dbClassicBooks.Select(x => x.ToClassicModel()).ToList();

            return model;
        }
    }
}
