using LibrarySystem.Interfaces.Bases.Models;

namespace LibrarySystem.LibraryService
{
    public class LibraryItemProcessor
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
        /// <summary>
        /// DVDの処理
        /// </summary>
        public static void Process(DVD dvd)
        {
            dvd.LendItem();
            dvd.Playback();
            dvd.ReturnItem();
        }
    }

}
