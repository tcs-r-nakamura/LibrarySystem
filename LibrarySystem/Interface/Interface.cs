using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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