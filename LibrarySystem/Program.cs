using LibrarySystem.Interface.Abstract.System;
using LibrarySystem.LibraryService;

namespace LibrarySystem
{
    /// <summary>
    /// エントリーポイント
    /// </summary>
    class Program
    {
            public static void Main(string[] args)
        {
            EBook ebook = new EBook("C#の教科書", 1, "佐藤 太郎");
          
       
            LibraryItemProcessor.Process(ebook);

            Console.WriteLine();

            DVD dvd = new DVD("トップガン", 2, "Tony Scott");
            LibraryItemProcessor.Process(dvd);
        }

    }
}
