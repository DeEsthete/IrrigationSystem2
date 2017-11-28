using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractProject
{
    class Information
    {
        private double _temperature;    //температура
        private double _humidity;       //влажность
        private double _reserveWater;//запас воды
        private DateTime _time;      //текущее время

        public Information(double temperature, double humidity, double reserveWater, DateTime time)
        {
            _temperature = temperature;
            _humidity = humidity;
            _reserveWater = reserveWater;
            _time = time;
        }

        public Information()
        {
            _temperature = 0;
            _humidity = 0;
            _reserveWater = 0;
            _time = DateTime.Now;
        }

        public Information(Information temp)
        {
            _temperature = temp.GetTemperature();
            _humidity = temp.GetHumidity();
            _reserveWater = temp.GetReserveWater();
            _time = DateTime.Now;
        }

        public double GetTemperature()
        {
            return _temperature;
        }

        public void SetTemperature(double temperature)
        {
            _temperature = temperature;
        }

        public double GetHumidity()
        {
            return (_humidity);
        }

        public void SetHumidity(double humidity)
        {
            _humidity = humidity;
        }

        public double GetReserveWater()
        {
            return _reserveWater;
        }

        public void SetReserveWater(double reserveWater)
        {
            _reserveWater = reserveWater;
        }

        public DateTime GetTime()
        {
            return _time;
        }
    }
}
