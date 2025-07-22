using LibrarySystem.Interface.Abstract;

namespace LibrarySystem.Interfaces.Bases.Models
{
    /// <summary>
    /// 書籍クラス
    /// </summary>
    public class Book : LibraryItem
    {
        public Book(string title, int id, string? author)
            : base(title, id, author)
        {
        }
    }

   