using LibrarySystem.Interface.Abstract.System;

namespace LibrarySystem.LibraryService
{
    public class LibraryItemProcessor
    {
        public static void Process(EBook ebook)
        {
            ebook.LendItem();
            ebook.Download();
            ebook.ReturnItem();
        }

        public static void Process(DVD dvd)
        {
            dvd.LendItem();
            dvd.Playback();
            dvd.ReturnItem();
        }
    }

}
