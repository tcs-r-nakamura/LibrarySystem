using LibrarySystem.Interface.Abstract;

namespace LibrarySystem.Interfaces.Bases.Models
{
    /// <summary>
    /// 雑誌クラス
    /// </summary>
   public class Magazine : LibraryItem
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="id">id</param>
        /// <param name="author">著者</param>
        public Magazine(string title, int id, string? author) : base(title, id, author)
        {
        }
    }
}
