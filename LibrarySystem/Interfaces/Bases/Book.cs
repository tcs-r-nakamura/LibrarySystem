using LibrarySystem.Interface;
using LibrarySystem.Interface.Abstract.System;

namespace LibrarySystem.Interface.Abstract.System
{
    public class Book : LibraryItem
    {
        public Book(string? title, int id, string? author)
            : base(title, id, author)
        {
        }
    }

    public class EBook : Book, IDownloadable
    {
        public EBook(string? title, int id, string? author)
            : base(title, id, author)
        {
        }

        public void Download()
        {
            Console.WriteLine($"『{Title}』をダウンロードします。");
        }
    }
}
