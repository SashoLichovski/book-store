﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Services.ViewModels
{
    public class HistoryBookViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int NumberOfPages { get; set; }
        [Required]
        public int Year { get; set; }
    }
}
