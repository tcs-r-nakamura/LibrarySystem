using LibrarySystem.Bases;
using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    /// <summary>
    /// DVDクラス
    /// </summary>
    public class DVD : LibraryItem, IPlayable
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="id">id</param>
        /// <param name="author">著者</param>
        public DVD(string title, int id, string? author) : base(title, id, author)
        {
        }

        /// <summary>
        /// 再生メソッド
        /// </summary>
        public void Playback()
        {
            Console.WriteLine($"『{Title}』を再生します。");
        }
    }
}
