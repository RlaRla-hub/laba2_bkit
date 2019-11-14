using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkit_2
{
    class Square : Rectangle, IPrint//интерфейс IPtint, наследование от Rectangle
    {
        public Square(double size) : base(size, size)
        {}//конструктор, принимающий сторону квадрата в качестве параметра
        //геометрическое определение квадрата, как прямоугольника с одинаковыми сторонами

        public override string ToString()//виртуальный метод для приведения к строковому типу
        {
            return "Квадрат площадью " + this.Area().ToString();
        }
    }
}