using BookStoreApi.Data;
using BookStoreApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}
