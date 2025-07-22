namespace LibrarySystem.Interface.Abstract
{
    public abstract class LibraryItem : ILendable, IReturnable
    {
        public string? Title { get; set; }
        public int Id { get; set; }
        public string? Author { get; set; }

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