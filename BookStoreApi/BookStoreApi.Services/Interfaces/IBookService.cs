using BookStoreApi.Services.ViewModels;

namespace BookStoreApi.Services.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetAll();
        void Delete(int bookId, string bookType);
        void Update(UpdateBookViewModel model);
        void Create(CreateBookViewModel model);
    }
}
