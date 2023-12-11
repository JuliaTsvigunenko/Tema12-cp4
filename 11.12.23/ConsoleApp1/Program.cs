using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //1
        static void Main(string[] args)
        {
            
            Figures figures = new Figures();
            figures.name = "Квадрат";
            figures.side1 = 5;
            figures.side2 = 5;
            Console.WriteLine(figures.ShowInfo());

            Console.WriteLine(figures.PP());

            Figures figures1 = new Figures();
            figures.name = "Прямоугольник";
            figures.side1 = 4;
            figures.side2 = 8;
            Console.WriteLine(figures.ShowInfo());


            /// <summary>
            /// Способ, где параметры вводятся с клавиатуры 
            /// </summary>
            Console.Write("Фигура: ");
            string name = Console.ReadLine();
            Console.Write("Сторона a: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона b: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона c: ");
            int side3 = Convert.ToInt32(Console.ReadLine());

            Figures figures3 = new Figures(name,side1,side2,side3);
            Console.WriteLine(figures3.ShowInfo());

            Figures figures4 = new Figures("Параллелограмм", 8, 3);
            Console.WriteLine(figures4.ShowInfo());



            Console.ReadKey();



        }
    }
}
