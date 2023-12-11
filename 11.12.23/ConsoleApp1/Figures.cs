using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс описывающий фигуру
    /// </summary>
    class Figures
    {


        /// <summary>
        /// создание поле имени
        /// </summary>
        public string name;

        /// <summary>
        /// создание поле стороны a
        /// </summary>
        public int side1;

        /// <summary>
        /// создание поле стороны b
        /// </summary>
        public int side2;

        /// <summary>
        /// создание поле стороны c
        /// </summary>
        public int side3;

        /// <summary>
        /// Конструктор по умолчанию(без параметров)
        /// </summary>
        public Figures()
        {
        }

        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Figures (string name, int side1, int side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Figures(string name, int side1, int side2,int side3):this(name,side1,side2)
        {
            this.side3 = side3;
        }

        /// <summary>
        /// Метод, который выводит информацию о фигуре 
        /// </summary>
        /// <returns></returns>
        public string ShowInfo()
        {
            return $"Фигура - {name}\nСторона a - {side1}\nСторона b - {side2}\nСторона с - {side3}";

        }

        /// <summary>
        /// Метод, который выводит информацию о периметре и площади квадрата 
        /// </summary>
        /// <returns></returns>
        public string PP()
        {
           return $"Периметр квадрата: {side1 * 4}\nПлощадь к" +
                $"вадрата: {Math.Pow(side1,2)}";
        }


    }
}
