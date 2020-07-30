using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApi.Services.ViewModels
{
    public class CreateBookViewModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int NumberOfPages { get; set; }
        public string Town { get; set; }
        public string Planet { get; set; }
        public int Year { get; set; }
    }
}
