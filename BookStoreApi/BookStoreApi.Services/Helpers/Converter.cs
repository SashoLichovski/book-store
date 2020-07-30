using BookStoreApi.Data;
using BookStoreApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BookStoreApi.Services.Helpers
{
    public static class Converter
    {
        public static FantasyBookViewModel ToFantasyModel(this FantasyBook x)
        {
            return new FantasyBookViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Amount = x.Amount,
                NumberOfPages = x.NumberOfPages,
                Planet = x.Planet,
                Price = x.Price
            };
        }

        public static ClassicBookViewModel ToClassicModel(this ClassicBook x)
        {
            return new ClassicBookViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Amount = x.Amount,
                NumberOfPages = x.NumberOfPages,
                Price = x.Price,
                Town = x.Town
            };
        }

        public static HistoryBookViewModel ToHistoryModel(this HistoryBook x)
        {
            return new HistoryBookViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Amount = x.Amount,
                NumberOfPages = x.NumberOfPages,
                Price = x.Price,
                Year = x.Year
            };
        }
    }
}
