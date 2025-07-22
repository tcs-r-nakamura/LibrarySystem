namespace LibrarySystem.Interface
{
    /// <summary>
    /// ダウンロード
    /// </summary>
    interface IDownloadable
    {
        void Download();
    }
    /// <summary>
    /// 再生
    /// </summary>
    interface IPlayable
    {
        void Playback();
    }
    /// <summary>
    /// 貸し出し
    /// </summary>
    interface ILendable
    {
        void LendItem();
    }
    /// <summary>
    /// 返却
    /// </summary>
    interface IReturnable
    {
        void ReturnItem();
    }
}