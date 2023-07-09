
namespace BookStore
{
    public interface IStoreFormPresenter
    {
        void OnAdd(object? sender, BookDataEventArgs book);

        void OnUpdate(object? sender, BookDataEventArgs book);

        void OnGetAll(object? sender, EventArgs e);

        void OnSearchInBooks(object? sender, SearchEventArgs e);
    }
}
