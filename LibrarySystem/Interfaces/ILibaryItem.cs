namespace LibrarySystem.Interfaces
{
    interface ILibaryItem
    {
        string Title { get; }
        int Id { get; }
        string? Author { get; }
    }
}
