using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Chap._2_The_Observer_Pattern
{
    public class WeatherData
    {

        /*
         * This methods called whenever the weather measurements
         * have been updated
         */

        public void getTemperature() { }
        public void getHumidity() { }
        public void getPressure() { }

        public void measurementsChanged() { }
    }
}
