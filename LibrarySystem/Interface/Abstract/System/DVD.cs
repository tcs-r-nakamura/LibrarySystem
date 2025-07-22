namespace LibrarySystem.Interface.Abstract.System
{
    public class DVD : LibraryItem, IPlayable
    {
        public DVD(string? title, int id, string? author) : base(title, id, author)
        {
        }

        public void Playback()
        {
            Console.WriteLine($"『{Title}』を再生します。");
        }
    }
}
