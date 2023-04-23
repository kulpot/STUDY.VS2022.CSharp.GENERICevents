using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERICevents
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.TopSpeedChanged += car_TopSpeedChanged;
            car.TopSpeed = 200;
        }

        private static void car_TopSpeedChanged(object sender, TopSpeedChangedEventArgs e)
        {
            Console.WriteLine("TopSpeed: " + ((Car)sender).TopSpeed);
            Console.ReadLine();
        }
    }
}