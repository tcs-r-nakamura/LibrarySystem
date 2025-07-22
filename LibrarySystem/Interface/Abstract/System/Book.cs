namespace LibrarySystem.Interface.Abstract.System
{
    class Book : LibraryItem
    {
        // NOP
    }

    class EBook : Book, IDownloadable
    {
        public void Download()
        {
            Console.WriteLine($"『{Title}』をダウンロードします。");
        }
    }
}
