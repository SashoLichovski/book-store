using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Data
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int NumberOfPages { get; set; }
    }
}
