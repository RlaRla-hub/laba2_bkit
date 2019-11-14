using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkit_2
{
    class Rectangle : Figures, IPrint //интерфейс IPtint, наследование от Figures
    {
        double high;//высота
        double width;//ширина
        public Rectangle()
        {
            this.high = 0;
            this.width = 0;
        }
        public Rectangle(double h, double w)//конструктор
        {
            this.high = h;
            this.width = w;
        }
        public override double Area()//площадь прямоугольника(переопределение)
        {
            double Result = this.width * this.high;
            return Result;
        }
        public override string ToString()//виртуальный метод для приведения к строковому типу
        {
            return "Прямоугольник площадью " + this.Area().ToString();
        }
        public void Print()//вывод данных о фигуре
        {
            Console.WriteLine(this.ToString());
        }
    }
}
