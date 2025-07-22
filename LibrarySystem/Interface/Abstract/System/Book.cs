namespace LibrarySystem.Interface.Abstract.System
{
    public class Book : LibraryItem
    {
        // NOP
    }

    public class EBook : Book, IDownloadable
    {
        public void Download()
        {
            Console.WriteLine($"『{Title}』をダウンロードします。");
        }
    }
}
