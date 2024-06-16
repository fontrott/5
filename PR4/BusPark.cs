using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PR4.Form1;

namespace PR4
{
    internal class BusPark
    {
        private List<Bus> buses;
        public BusPark()
        {
            buses = new List<Bus>();
        }
        public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }
    }
}
