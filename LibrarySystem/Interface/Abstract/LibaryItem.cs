namespace LibrarySystem.Interface.Abstract
{
    public abstract class LibraryItem : ILendable, IReturnable
    {
        public string? Title { get; private set; }
        public int Id { get; private set; }
        public string? Author { get; private set; }

        public LibraryItem(string? title, int id, string? author)
        {
            Title = title;
            Id = id;
            Author = author;
        }

        public void LendItem()
        {
            Console.WriteLine($"『{Title}』を貸し出します。");
        }

        public void ReturnItem()
        {
            Console.WriteLine($"『{Title}』を返却しました。");
        }
    }
}