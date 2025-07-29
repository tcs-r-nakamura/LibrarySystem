using LibrarySystem.Bases;
using LibrarySystem.Interfaces;

namespace LibrarySystem.LibraryServices
{
    public class LibraryItemManager<T> : ILibraryItemManager<T> where T : LibraryItem
    {
        private readonly List<T> items;
        private readonly Action<T> processAction;

        public LibraryItemManager(List<T> initialItems, Action<T> process)
        {
            items = initialItems;
            processAction = process;
        }
        
        public T? FindById(int id)
        {
            return items.Find(item => item.Id == id);
        }

        public T? FindByTitle(string title)
        {
            return items.Find(item => item.Title == title);
        }

        public void Process(T item)
        {
            processAction(item);
        }
    }
}
