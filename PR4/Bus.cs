using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public class Bus<T1, T2, T3, T4>
    {
        public T1 BusNumber { get; set; }
        public T2 DriverNameAndSurname { get; set; }
        public T3 RouteNumber { get; set; }
        public T4 OnTheRoute { get; set; }

        public Bus(T1 busNumber, T2 driverNameAndSurname, T3 routeNumber, T4 onTheRoute)
        {
            BusNumber = busNumber;
            DriverNameAndSurname = driverNameAndSurname;
            RouteNumber = routeNumber;
            OnTheRoute = onTheRoute;
        }

        public delegate void AddBusDelegate(List<Bus<T1, T2, T3, T4>> buses, T1 busNumber, T2 driverNameAndSurname, T3 routeNumber, T4 onTheRoute);
        public static AddBusDelegate AddNewBus;

        public delegate void UpdateBusInfoDelegate(List<Bus<T1, T2, T3, T4>> buses, TextBox busesTextBox);
        public static UpdateBusInfoDelegate UpdateBusInfo;
        public void UpdateBusNumber(T1 BusNumber)
        {
            this.BusNumber = BusNumber;
        }
        public void UpdateDriverNameAndSurname(T2 DriverNameAndSurname)
        {
            this.DriverNameAndSurname = DriverNameAndSurname;
        }
        public void UpdateBusNumber(T3 RouteNumber)
        {
            this.RouteNumber = RouteNumber;
        }
        public void UpdateOnTheRoute(T4 OnTheRoute)
        {
            this.OnTheRoute = OnTheRoute;
        }
    }
}
