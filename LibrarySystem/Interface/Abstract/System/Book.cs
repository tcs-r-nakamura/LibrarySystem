using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Interface.Abstract.System
{
    class Book : LibraryItem
    {
        // NOP
    }

    class EBook : Book, IDownloadable
    {
        public void Download()
        {
            Console.WriteLine($"『{Title}』をダウンロードします。");
        }
    }
}
