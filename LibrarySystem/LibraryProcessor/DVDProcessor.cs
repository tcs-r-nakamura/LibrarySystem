using LibrarySystem.LibraryServices;
using LibrarySystem.Models;

namespace LibrarySystem.LibraryProcessor
{
public class DVDProcessor
    {
        public void Process()
        {
            var dvds = new List<DVD>
        {
            new DVD("トップガン", 2, "Tony Scott"),
            new DVD("インセプション", 5, "Christopher Nolan")
        };

            var dvdManager = new LibraryItemManager<DVD>(
                dvds,
                dvd =>
                {
                    dvd.LendItem();
                    dvd.Playback();
                    dvd.ReturnItem();
                }
            );

            var dvd = dvdManager.FindById(5);
            if (dvd != null)
                dvdManager.Process(dvd);
        }
    }

}
