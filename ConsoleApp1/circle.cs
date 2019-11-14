using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkit_2
{
    class Circle : Figures, IPrint//интерфейс IPtint, наследование от Figures
    {
        double radius;//радиуc
        public Circle(double r)//конструктор
        {
            this.radius = r;
            this.Type = "Круг";
        }
        public override double Area()//площадь круга (переопределение)
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }
        public override string ToString()//виртуальный метод для приведения к строковому типу
        {
            return "Окружность площадью " + this.Area().ToString();
        }
        public void Print()//вывод данных о фигуре
        {
            Console.WriteLine(this.ToString());
        }
    }
}