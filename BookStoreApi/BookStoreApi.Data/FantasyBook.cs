using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Data
{
    public class FantasyBook : Book
    {
        [Required]
        public string Planet { get; set; }
    }
}
