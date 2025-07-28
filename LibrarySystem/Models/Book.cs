using LibrarySystem.Bases;

namespace LibrarySystem.Models
{
    /// <summary>
    /// 書籍クラス
    /// </summary>
    public class Book : LibraryItem
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="id">id</param>
        /// <param name="author">著者</param>
        public Book(string title, int id, string? author)
            : base(title, id, author)
        {
        }
    }
}