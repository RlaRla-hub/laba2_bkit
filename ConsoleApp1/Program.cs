using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkit_2
{
    class ProgramLR2
    {
        static void Main(string[] args)
        {
            Console.Title = "Бочарова Маргарита РТ5-31Б";
            Circle o_1 = new Circle(32);//создаём объект круг и передаём параметр в конструктор
            Rectangle o_2 = new Rectangle(4, 5);//прямоугольник
            Square o_3 = new Square(23);//квадрат
            Console.ForegroundColor = ConsoleColor.Yellow;
            o_1.Print();//Вывод данных о круге
            Console.ForegroundColor = ConsoleColor.Blue;
            o_2.Print();//Вывод данных о прямоугольнике
            Console.ForegroundColor = ConsoleColor.Magenta;
            o_3.Print();//Вывод данных о квадрате   
            Console.ReadLine();
        }
    }
}