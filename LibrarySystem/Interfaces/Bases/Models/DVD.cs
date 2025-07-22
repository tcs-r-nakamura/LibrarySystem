using LibrarySystem.Interface;
using LibrarySystem.Interface.Abstract;

namespace LibrarySystem.Interfaces.Bases.Models
{
    /// <summary>
    /// DVDクラス
    /// </summary>
    public class DVD : LibraryItem, IPlayable
    {

        public DVD(string title, int id, string? author) : base(title, id, author)
        {
        }

        public void Playback()
        {
            Console.WriteLine($"『{Title}』を再生します。");
        }
    }
}
