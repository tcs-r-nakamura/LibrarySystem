using LibrarySystem.Interface.Abstract.System;
using LibrarySystem.LibraryService;

namespace LibrarySystem
{

    class Program
    {
            public static void Main(string[] args)
        {
            EBook ebook = new EBook
            {
                Title = "C#の教科書",
                Author = "佐藤 太郎",
                Id = 1
            };
            LibraryItemProcessor.Process(ebook);

            Console.WriteLine();

            DVD dvd = new DVD
            {
                Title = "トップガン",
                Author = "Tony Scott",
                Id = 2
            };
            LibraryItemProcessor.Process(dvd);
        }

    }
}
