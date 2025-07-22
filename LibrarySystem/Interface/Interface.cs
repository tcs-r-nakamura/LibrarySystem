namespace LibrarySystem.Interface
{
    interface IDownloadable
    {
        void Download();
    }

    interface IPlayable
    {
        void Playback();
    }

    interface ILendable
    {
        void LendItem();
    }

    interface IReturnable
    {
        void ReturnItem();
    }
}