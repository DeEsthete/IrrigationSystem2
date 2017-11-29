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
        private int _countOfVegetables = 0;

        Hub()
        {
            _vegetables = new IrrigationSystem[++_countOfVegetables]; 
        }
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
        public void Menu()
        {
            Console.WriteLine("Система планирования автоматического орошения полей.");
            Console.WriteLine("Выберите вид орашаемого поля:" + "1-Зерновые и хлебные злаки." + "2-Овощные" + "3-Плодовые растения");
            Console.WriteLine("Выберите стадию развития и роста:");
            Console.WriteLine("1-эмбриональный (семенной или половой)" + "2-ювенильный, или молодости" + "3-зрелости (половой или вегетативной)"
                + "4-размножения (полового или вегетативного)");
            SetStage(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите имеющийся запас воды в резервуарах (литрах):");
            SetNeedWater(double.Parse(Console.ReadLine()));

        }
    }
}
