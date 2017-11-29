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

        public bool IsHumidity()//проверка на влажность
        {
            if (_vegetables.GetInformatin().GetHumidity() < _vegetables.GetNeedWater())
            {
                _vegetables.GetInformatin().SetHumidity(_vegetables.GetNeedWater());
                _vegetables.GetInformatin().SetReserveWater(_vegetables.GetNeedWater() - _vegetables.GetInformatin().GetHumidity());
                return true;
            }
            else
            {
                Console.WriteLine("Не достаточно воды для полива !!!!");
                return false;
            }
        }

        public bool IsTemperature()//проверка на температуру
        {
            //Todo
        }

        public bool IsWater()//проверка на воду
        {
            //ToDo
        }
    }
}
