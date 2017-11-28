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
        public IrrigationSystem(Vegetables vegetables)
        {
            _vegetables.SetName(vegetables.GetName());
            _vegetables.SetStage(vegetables.GetStage());
            _vegetables.SetNeedWater(vegetables.GetNeedWater());
            _vegetables.SetInformation(vegetables.GetInformatin());
        }
    }
}
