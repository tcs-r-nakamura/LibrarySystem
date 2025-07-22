namespace LibrarySystem.Interface.Abstract
{
    public abstract class LibraryItem : ILendable, IReturnable
    {
        /// <summary>
        /// 抽象クラス
        /// </summary>
        public string? Title { get; private set; }
        public int Id { get; private set; }
        public string? Author { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="id">ID</param>
        /// <param name="author">著者</param>
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