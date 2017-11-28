using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractProject
{
    public class Hub
    {
        bool _turnON;  //включена ли система
        //Static statistic;
        private Information _info;
        private Static _stat;
        private IrrigationSystem[] _vegetables;

        public bool GetTurnOn()
        {
            return _turnON;
        }

        public void SetTurnOn(bool turnON)
        {
            _turnON = turnON;
        }

        public Information GetInfo()
        {
            return _info;
        }

        public void SetInfo(Information info)
        {
            _info = info;
        }

        public Static GetStat()
        {
            return _stat;
        }

        public void SetStat(Static stat)
        {
            _stat = stat;
        }
    }
}
