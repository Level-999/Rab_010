using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rab_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
            //Реализовать класс, в котором указанные значения представлены в виде свойств.
            //Для свойств предусмотреть проверку корректности данных.
            //Класс должен содержать конструктор для установки начальных значений,
            //а также метод ToRadians для перевода угла в радианы.
            //Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
            
            Angle angle;
            do
            {
                Console.WriteLine("Ввод данных, задаём угол");
                int gradus1 = Convert.ToInt32(Console.ReadLine());
                int min1 = Convert.ToInt32(Console.ReadLine());
                int sec1 = Convert.ToInt32(Console.ReadLine());

                angle = new Angle(gradus1, min1, sec1);
            }
           

            while (angle.isCorrect == false);
            int totalgradus = angle.ToRadians();

            Console.WriteLine(totalgradus);
            Console.ReadKey();
        }
    }
}
