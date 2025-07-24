using LibrarySystem.Bases.Models;

namespace LibrarySystem.LibraryServices
{
    public class DVDManager
    {
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

