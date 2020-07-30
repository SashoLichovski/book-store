using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Data
{
    public class HistoryBook : Book
    {
        [Required]
        public int Year { get; set; }
    }
}
