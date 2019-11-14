using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkit_2
{
    abstract class Figures//абстрактный класс «Геометрическая фигура»
    {
        public string Type//тип фигуры
        {
            get
            {
                return this._Type;
            } protected set
            {
                this._Type = value;
            }
        }
        string _Type;
        public abstract double Area();//абстрактный метод вычисления площади
    }
}
