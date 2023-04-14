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
      double[] EnterLineData
        {
         double[] arr = new double[3];
         Console.WriteLine("Введите коэффициенты для уравнения прямой A*x+B*y=C");
         Console.Write("Введите A: ");
         arr[0] = double.Parse(Console.ReadLine() ?? "0");
         Console.Write("Введите B: ");
         arr[1] = double.Parse(Console.ReadLine() ?? "0");
         Console.Write("Введите C: ");
         arr[2] = double.Parse(Console.ReadLine() ?? "0");
         return arr;
       }

      bool ParallYesNo(double arrFirstLine, double arrSecondLine)
          {
            bool res = false;
            if (arrFirstLine[0]*arrSecondLine[1]==arrSecondLine[0]*arrFirstLine[1]) 
        {
          res = true;
        }
            return res;
        }

    double[] PointKoord(double[] arrLnFir, double[] arrLnSc)
          {
            double[] koord = new double[2]
koord[0] = ((arrLnFir[2]*arrLnSc[1])-(arrLnSc[2]*arrLnFir[1]))/((arrLnFir[0]*arrLnSc[1])-(arrLnSc[0]*arrLnFir[1]));

            koord[1] = ((arrLnFir[0]*arrLnSc[2])-(arrLnSc[0]*arrLnFir[2]))/((arrLnFir[0]*arrLnSc[1])-(arrLnSc[0]*arrLnFir[1]));
            
          }


          double LenSegm(double[] firKoor, double[] secKoor)
          {
           int len = Math.Sqrt(((secKoor[0]-firKoor[0])*(secKoor[0]-firKoor[0])) - ((secKoor[1]-firKoor[1])*(secKoor[1]-firKoor[1])));
            len = Abs(len);
            return len;
          }
            
          
          double[] datLinFir = EnterLineData;
          double[] datLinSec = EnterLineData;
        if (ParallYesNo(datLinFir,datLinSec)) 
          {
            Console.WriteLine("Прямые параллельные и не пересекаются");
            break;       
          }
        double[] pointXY = PointKoord(datLinFir,datLinSec);  
    
    }
}
