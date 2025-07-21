using System;

interface IDownloadable
{
    void Download();
}

interface IPlayable
{
    void Playback();
}

abstract class LibraryItem
{
    public string Title { get; set; }
    public int Id { get; set; }
    public string Author { get; set; } 

    public void LendItem()
    {
        Console.WriteLine($"『{Title}』を貸し出します。");
    }

    public void ReturnItem()
    {
        Console.WriteLine($"『{Title}』を返却しました。");
    }
}

class Book : LibraryItem
{
}

class EBook : Book, IDownloadable
{
    public void Download()
    {
        Console.WriteLine($"『{Title}』をダウンロードします。");
    }
}

class Magazine : LibraryItem
{
}

class DVD : LibraryItem, IPlayable
{
    public void Playback()
    {
        Console.WriteLine($"『{Title}』を再生します。");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        EBook ebook = new EBook
        {
            Title = "C#の教科書",
            Author = "佐藤 太郎",
            Id = 1
        };
        ebook.LendItem();
        ebook.Download();
        ebook.ReturnItem();

        Console.WriteLine();

        DVD dvd = new DVD
        {
            Title = "トップガン",
            Author = "Tony Scott",
            Id = 2
        };
        dvd.LendItem();
        dvd.Playback();
        dvd.ReturnItem();
    }
}
