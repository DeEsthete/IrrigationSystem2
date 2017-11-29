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
        private double _needWater;//необходимый уровень влажности в поле
        private Information _info;
        private int _square;//площадь поля 
        private double _needWaterOnSquareMeter;//Количество воды на квадратный метр

        Vegetables(string name,int stage,double needWater,Information info,int square) {
            _name = name;
            _stage = stage;
            _needWater = needWater;
            _info = info;
            _square = square;
        }
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

        public void SetNeedWater(double needWater)
        {
            string text = ReadLine();

            bool isParsed = double.TryParse(text, out needWater);
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

        public int GetSquare()
        {
            return (_square);
        }

        public void SetSquare(int square)
        {
            _square = square;
        }

        public void SetNeedWaterOnSquareMeter(int waterSquare)
        {
            _needWaterOnSquareMeter = waterSquare;
        }

        public void CalculationNeedWater()//расчитывает необходимую влажность для поля 
        {
            _needWater = _needWaterOnSquareMeter * _square;
        }
    }
}
