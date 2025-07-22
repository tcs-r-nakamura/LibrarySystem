using LibrarySystem.Interface.Abstract;

namespace LibrarySystem.Interfaces.Bases.Models
{
    /// <summary>
    /// 雑誌クラス
    /// </summary>
   public class Magazine : LibraryItem
    {
        public Magazine(string title, int id, string? author) : base(title, id, author)
        {
        }
    }
}
