using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractProject
{
    public class IrrigationSystem
    {
        private Vegetables _vegetables;
        private Static _stat;

        public Vegetables GetVegetables()
        {
            return _vegetables;
        }

        public void SetVegetables(Vegetables vegetables)
        {
            _vegetables = vegetables;
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
