using BookStoreApi.Data;
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

        public void Create(CreateBookViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Planet))
            {
                var newBook = new FantasyBook()
                {
                    Title = model.Title,
                    Author = model.Author,
                    Amount = model.Amount,
                    NumberOfPages = model.NumberOfPages,
                    Price = model.Price,
                    Planet = model.Planet
                };
                bookRepo.AddFantasy(newBook);
            }
            else if (!string.IsNullOrEmpty(model.Town))
            {
                var newBook = new ClassicBook()
                {
                    Title = model.Title,
                    Author = model.Author,
                    Amount = model.Amount,
                    NumberOfPages = model.NumberOfPages,
                    Price = model.Price,
                    Town = model.Town
                };
                bookRepo.AddClassic(newBook);
            }
            else
            {
                var newBook = new HistoryBook()
                {
                    Title = model.Title,
                    Author = model.Author,
                    Amount = model.Amount,
                    NumberOfPages = model.NumberOfPages,
                    Price = model.Price,
                    Year = model.Year
                };
                bookRepo.AddHistory(newBook);
            }
        }

        public void Delete(int bookId, string bookType)
        {
            bookRepo.Delete(bookId, bookType);
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

        public void Update(UpdateBookViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Town))
            {
                var dbBook = bookRepo.GetClassicById(model.Id);
                dbBook.NumberOfPages = model.NumberOfPages;
                dbBook.Title = model.Title;
                dbBook.Author = model.Author;
                dbBook.Price = model.Price;
                dbBook.Town = model.Town;
                dbBook.Amount = model.Amount;
                bookRepo.UpdateClassicBook(dbBook);
            }
            else if (!string.IsNullOrEmpty(model.Planet))
            {
                var dbBook = bookRepo.GetFantasyById(model.Id);
                dbBook.NumberOfPages = model.NumberOfPages;
                dbBook.Title = model.Title;
                dbBook.Author = model.Author;
                dbBook.Price = model.Price;
                dbBook.Planet = model.Planet;
                dbBook.Amount = model.Amount;
                bookRepo.UpdateFantasyBook(dbBook);

            }
            else
            {
                var dbBook = bookRepo.GetHistoryById(model.Id);
                dbBook.NumberOfPages = model.NumberOfPages;
                dbBook.Title = model.Title;
                dbBook.Author = model.Author;
                dbBook.Price = model.Price;
                dbBook.Year = model.Year;
                dbBook.Amount = model.Amount;
                bookRepo.UpdateHistoryBook(dbBook);

            }
        }
    }
}
