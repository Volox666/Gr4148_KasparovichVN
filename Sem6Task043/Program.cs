// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

using System;
namespace project
{
    class Program
    {
        static void Main()
        {
            double[] EnterLineData(string msg)    // Метод получает коэффициенты для уравнений прямых
            {
                double[] arr = new double[3];
                Console.WriteLine("Введите коэффициенты для уравнения прямой {0} A*x+B*y=C", msg);
                Console.Write("Введите A: ");
                arr[0] = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("Введите B: ");
                arr[1] = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("Введите C: ");
                arr[2] = double.Parse(Console.ReadLine() ?? "0");
                return arr;
            }

            void Print1DArr(double[] arr) // метод вывода массива в консоль
            {
                System.Console.Write("[");
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    System.Console.Write(arr[i] + ", ");
                }
                System.Console.WriteLine(arr[arr.Length - 1] + "]");
            }

            bool ParallYesNo(double[] arrFirstLine, double[] arrSecondLine) // Метод проверяет параллельность прямых
            {
                bool res = false;
                if (arrFirstLine[0] * arrSecondLine[1] == arrSecondLine[0] * arrFirstLine[1])
                {
                    res = true;
                }
                return res;
            }

            double[] PointKoord(double[] arrLnFir, double[] arrLnSc) // Метод находит координату точки пересечения прямых 
            {
                double[] koord = new double[2];
                koord[0] = ((arrLnFir[2] * arrLnSc[1]) - (arrLnSc[2] * arrLnFir[1])) / ((arrLnFir[0] * arrLnSc[1]) - (arrLnSc[0] * arrLnFir[1]));
                koord[1] = ((arrLnFir[0] * arrLnSc[2]) - (arrLnSc[0] * arrLnFir[2])) / ((arrLnFir[0] * arrLnSc[1]) - (arrLnSc[0] * arrLnFir[1]));
                return koord;
            }


            double LenSegm(double[] firKoor, double[] secKoor) // Метод считает длину отрезка между точками
            {
                double len = Math.Sqrt(Math.Pow((secKoor[0] - firKoor[0]), 2) - Math.Pow((secKoor[1] - firKoor[1]), 2));
                len = Math.Abs(len);
                return len;
            }

            double SqTriangle(double a, double b, double c) // Метод считает площадь треугольника по его сторонам
            {
                double halfPer = (a + b + c) / 2;
                double resS = (halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));
                resS = Math.Abs(resS);
                double resSq = Math.Sqrt(resS);
                return resSq;
            }

            // Решение обычной задачи


            double[] datLinFir = EnterLineData("1");
            double[] datLinSec = EnterLineData("2");
            if (ParallYesNo(datLinFir, datLinSec))
            {
                Console.WriteLine("Прямые параллельные и не пересекаются");
                System.Environment.Exit(1);
            }

            double[] pointXY = PointKoord(datLinFir, datLinSec);
            System.Console.Write("Координаты точки пересечения прямых: ");
            Print1DArr(pointXY);

            // Решение для задачи *

            double[] datLineFir = EnterLineData("1");
            double[] datLineSec = EnterLineData("2");
            double[] datLineThir = EnterLineData("3");

            if (ParallYesNo(datLineFir, datLineSec) || ParallYesNo(datLineThir, datLineSec) || ParallYesNo(datLineFir, datLineThir))
            {
                Console.WriteLine("Прямые параллельные и не пересекаются");
                System.Environment.Exit(1);
            }

            double[] pointAxy = PointKoord(datLineFir, datLineSec);
            double[] pointBxy = PointKoord(datLineFir, datLineThir);
            double[] pointCxy = PointKoord(datLineThir, datLineSec);

            double segmA = LenSegm(pointAxy, pointBxy);
            double segmB = LenSegm(pointBxy, pointCxy);
            double segmC = LenSegm(pointAxy, pointCxy);

            double trianglSq = SqTriangle(segmA, segmB, segmC);

            System.Console.WriteLine("Площадь треугольника: " + trianglSq);







        }
    }
}
