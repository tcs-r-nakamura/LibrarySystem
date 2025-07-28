    using LibrarySystem.LibraryServices;
    using LibrarySystem.Models;

namespace LibrarySystem.LibraryProcessor
{
    public class MagazineProcessor
    {
        public void Process()
        {
            var magazines = new List<Magazine>
        {
            new Magazine("ワンピース", 3, "尾田 栄一郎"),
            new Magazine("ナショナルジオグラフィック", 6, "National Geographic Society")
        };

            var magazineManager = new LibraryItemManager<Magazine>(
                magazines,
                magazine =>
                {
                    magazine.LendItem();
                    magazine.ReturnItem();
                }
            );

            var magazine = magazineManager.FindByTitle("ワンピース");
            if (magazine != null)
                magazineManager.Process(magazine);
        }
    }

}
