using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public interface IPresenter
    {
        void AddCity(City c1);
        void RemoveCity(string name);
        bool CityExists(string name);
        void ComputeRoute(string city1, string city2);
        City GetCity(string name);
        void Init();
        void Exit();
    }
}
