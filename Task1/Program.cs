using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static void Main(string[] args)
    {
        ArithProgression ap = new ArithProgression();
        GeometrProgression gp = new GeometrProgression();
        Console.WriteLine("Введите первый член прогрессии");
        int a = Convert.ToInt32(Console.ReadLine());
        ap.SetStart(a);
        gp.SetStart(a);
        Console.WriteLine("Введите шаг прогрессии");
        ap.A = Convert.ToInt32(Console.ReadLine());
        gp.B = ap.A;
        Console.WriteLine("Пять членов арифметической прогрессии");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{ap.GetNext()} ");
        }
        ap.Reset();
        Console.WriteLine();
        Console.WriteLine("Пять членов геометрической прогрессии");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{gp.GetNext()} ");
        }
        gp.Reset();
        Console.ReadKey();


    }
}
