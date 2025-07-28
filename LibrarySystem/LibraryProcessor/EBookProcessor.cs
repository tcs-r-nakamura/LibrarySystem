    using LibrarySystem.LibraryServices;
    using LibrarySystem.Models;

namespace LibrarySystem.LibraryProcessor
{
    public class EBookProcessor
    {
        public void Process()
        {
            var ebooks = new List<EBook>
        {
            new EBook("C#の教科書", 1, "佐藤 太郎"),
            new EBook("Java入門", 4, "田中 次郎")
        };

            var ebookManager = new LibraryItemManager<EBook>(
                ebooks,
                ebook =>
                {
                    ebook.LendItem();
                    ebook.Download();
                    ebook.ReturnItem();
                }
            );

            var ebook = ebookManager.FindByTitle("C#の教科書");
            if (ebook != null)
                ebookManager.Process(ebook);
        }
    }

}
