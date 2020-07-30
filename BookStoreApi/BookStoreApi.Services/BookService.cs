using BookStoreApi.Repositories.Interfaces;
using BookStoreApi.Services.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}
