using LibrarySystem.Interfaces;

namespace LibrarySystem.Bases
{
    public abstract class LibraryItem : ILendable, IReturnable
    {
        /// <summary>
        /// プロパティ
        /// </summary>
        public string Title { get; private set; }
        public int Id { get; private set; }
        public string? Author { get; private set; } 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="id">ID</param>
        /// <param name="author">著者</param>
        public LibraryItem(string title, int id, string? author)
        {
            Title = title;
            Id = id;
            Author = author;
        }
     
        /// <summary>
        /// 貸し出しメソッド
        /// </summary>
        public void LendItem()
        {
            Console.WriteLine($"『{Title}』を貸し出します。");
        }

        /// <summary>
        /// 返却メソッド
        /// </summary>
        public void ReturnItem()
        {
            Console.WriteLine($"『{Title}』を返却しました。");
        }
    }
}