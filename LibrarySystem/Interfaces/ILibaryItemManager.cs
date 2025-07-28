using LibrarySystem.Bases;

namespace LibrarySystem.Interfaces
{
    public interface ILibraryItemManager<T> where T : LibraryItem
    {
        T? FindById(int id);
        T? FindByTitle(string title);
        void Process(T item);
    }
}
