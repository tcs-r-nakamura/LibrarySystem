using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
