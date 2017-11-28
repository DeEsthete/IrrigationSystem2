using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractProject
{
    public class Static
    {
        private double _lastWater;      //вода      //литр
        private double _lastEnergy;     //энергия   //ват
        private DateTime _lastWatering; //последнее вемя поливки
        private DateTime _assumeWatering;       //предпологаемое время поливки

        public Static(double lastWater, double lastEnergy, DateTime lastWatering, DateTime assumeWatering)
        {
            _lastWater = lastWater;
            _lastEnergy = lastEnergy;
            _lastWatering = lastWatering;
            _assumeWatering = assumeWatering;
        }

        public Static()
        {
            _lastWater = 0;
            _lastEnergy = 0;
            _lastWatering = DateTime.Now;
            _assumeWatering = DateTime.Now;
        }

        public double GetLastWater()
        {
            return _lastWater;
        }

        public void SetLastWater(double lastWater)
        {
            _lastWater = lastWater;
        }

        public double GetLastEnergy(double lastEnergy)
        {
            return _lastEnergy;
        }

        public void SetLastEnergy(double lastEnergy)
        {
            _lastEnergy = lastEnergy;
        }

        public DateTime GetLastWatering()
        {
            return _lastWatering;
        }

        public void SetLastWatering(DateTime lastWatering)
        {
            _lastWatering = lastWatering;
        }

        public DateTime GetAssumeWatering()
        {
            return _assumeWatering;
        }
        public void SetAssumeWatering(DateTime assumeWatering)
        {
            _assumeWatering = assumeWatering;
        }
    }
}
