namespace LibrarySystem.Interface.Abstract.System
{
    public class DVD : LibraryItem, IPlayable
    {
        public void Playback()
        {
            Console.WriteLine($"『{Title}』を再生します。");
        }
    }
}
