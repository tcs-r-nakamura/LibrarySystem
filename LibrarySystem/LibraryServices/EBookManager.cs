using LibrarySystem.Bases.Models;

namespace LibrarySystem.LibraryService
{
    public class EBookManager
    {
        /// <summary>
        /// 電子書籍の処理
        /// </summary>
        public static void Process(EBook ebook)
        {
            ebook.LendItem();
            ebook.Download();
            ebook.ReturnItem();
        }
    }
}
