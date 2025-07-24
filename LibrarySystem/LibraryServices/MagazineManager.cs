using LibrarySystem.Bases.Models;

namespace LibrarySystem.LibraryServices
{
    public class MagazineManager
    {
        /// <summary>
        /// DVDの処理
        /// </summary>
        public static void Process(Magazine magazine)
        {
            magazine.LendItem();
            magazine.ReturnItem();
        }
    }
}

