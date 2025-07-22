using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Interface.Bases
{
    /// <summary>
    /// 電子書籍クラス
    /// </summary>
    public class EBook : Book, IDownloadable
    {
        public EBook(string title, int id, string? author)
            : base(title, id, author)
        {
        }

        public void Download()
        {
            Console.WriteLine($"『{Title}』をダウンロードします。");
        }
    }
}
