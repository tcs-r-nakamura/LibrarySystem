namespace LibrarySystem.LibraryProcessor
{
    public class LibraryProcessor
    {
        public void Run()
        {
            new EBookProcessor().Process();
            new DVDProcessor().Process();
            new MagazineProcessor().Process();
        }
    }
}