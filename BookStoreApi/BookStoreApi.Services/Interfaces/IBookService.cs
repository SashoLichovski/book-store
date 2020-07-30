using BookStoreApi.Services.ViewModels;

namespace BookStoreApi.Services.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetAll();
    }
}
