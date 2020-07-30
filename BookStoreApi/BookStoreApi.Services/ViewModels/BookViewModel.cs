using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApi.Services.ViewModels
{
    public class BookViewModel
    {
        public List<HistoryBookViewModel> HistoryBooks { get; set; }
        public List<FantasyBookViewModel> FantasyBooks { get; set; }
        public List<ClassicBookViewModel> ClassicBooks { get; set; }
    }
}
