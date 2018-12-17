using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structure_Pattern.Facade
{
    public interface IHomeTheater
    {
        void WatchMovie(string movie);
        void EndMovie();
        void ListenTCd(string cd);
        void EndCd();
        void ListenToRadio(string station);
        void EndRadio();
    }
}
