using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PractProject
{
    public class Vegetables
    {
        private string _name;    //имя
        private int _stage;      //стадия
        private double _needWater;
        private Information _info;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            Write("Введите имя овощи: ");
            name = ReadLine();
            this._name = name;
        }

        public int GetStage()
        {
            return _stage;
        }

        public void SetStage(int stage)
        {
            Write("Введите стадию роста: ");
            string text = ReadLine();

            bool isParsed = int.TryParse(text, out stage);

            if (!isParsed)
            {
                WriteLine("Ошибка");
                return;
            }
            this._stage = stage;
        }

        public double GetNeedWater()
        {
            return _needWater;
        }

        public void SetNeedWater(int needWater)
        {
            string text = ReadLine();

            bool isParsed = int.TryParse(text, out needWater);
            if (!isParsed)
            {
                Write("Ошибка!");
                return;
            }
            this._needWater = needWater;

        }

        public Information GetInformatin()
        {
            return _info;
        }

        public void SetInformation(Information info)
        {
            _info = info;
        }
    }
}
