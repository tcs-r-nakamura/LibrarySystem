using LibrarySystem.Bases.Models;
using LibrarySystem.LibraryService;
using LibrarySystem.LibraryServices;

namespace LibrarySystem
{
    /// <summary>
    /// エントリーポイント
    /// </summary>
    class Program
    {
        /// <summary>
        /// インスタンス生成
        /// </summary>
        /// <param name="args">未使用</param>
            public static void Main(string[] args)
        {
            EBook ebook = new EBook("C#の教科書", 1, "佐藤 太郎");
            EBookManager.Process(ebook);

            Console.WriteLine();

            DVD dvd = new DVD("トップガン", 2, "Tony Scott");
            DVDManager.Process(dvd);

            Console.WriteLine();

            Magazine magazine = new Magazine("ワンピース", 3, "尾田 栄一郎");
            MagazineManager.Process(magazine);
        }
    }
}