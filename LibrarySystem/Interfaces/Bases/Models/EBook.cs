using LibrarySystem.Interface;

namespace LibrarySystem.Interfaces.Bases.Models
{
    /// <summary>
    /// 電子書籍クラス
    /// </summary>
    public class EBook : Book, IDownloadable
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="id">id</param>
        /// <param name="author">著者</param>
        public EBook(string title, int id, string? author)
            : base(title, id, author)
        {
        }

        public void Download()
        {
            Console.WriteLine($"『{Title}』をダウンロードします。");
        }
    }
}
