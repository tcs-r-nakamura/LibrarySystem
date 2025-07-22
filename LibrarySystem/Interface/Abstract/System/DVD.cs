namespace LibrarySystem.Interface.Abstract.System
{
    class DVD : LibraryItem, IPlayable
    {
        public void Playback()
        {
            Console.WriteLine($"『{Title}』を再生します。");
        }
    }
}
