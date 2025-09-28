using System;

//Массивы в качестве параметров
// Homework_2.4
// Homework_5.4

namespace ArraysForParameters
{
   internal class Program
   {
      static void Main(string[] args)
      {
         string nameArrayOne = "C";
         string nameArrayTwo = "P";
         int size = NumberArrayElements();
         double[] vectorC = EnterArrayDouble(size, nameArrayOne);
         double[] vectorP = EnterArrayDouble(size, nameArrayTwo);

         // *Это можно не выводить
         //Console.WriteLine("Массив: ");
         //for (int i = 0; i < vectorC.Length; i++)
         //{
         //   Console.WriteLine("{0:f} ", vectorC[i]);
         //}
         // *

         Console.ReadKey();
      }

      public static double[] EnterArrayDouble(int size, string name)
      {
         double[] vector = new double[size];
         Console.WriteLine("Введите вектор {0}", name);
         int i = 0;
         while (i < vector.Length)
         {
            Console.Write("Введите элемент под номером {0}: ", i);
            double.TryParse(Console.ReadLine(), out vector[i]);
            //vector[i] = Convert.ToDouble(Console.ReadLine());
            i++;
         }



         return vector;
      }

      public static int NumberArrayElements()
      {
         int n;
         do
         {
            Console.WriteLine("Введите размер векторов:");
            int.TryParse(Console.ReadLine(), out n);
            //n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || n > 20)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (n <= 0 || n > 20);

         return n;
      }
   }

   //setlocale(LC_ALL, "Russian");
   //int n;
   //printf("Введите размер векторов\n");
   //scanf("%i", &n);
   //float* C;
   //float* P;
   //printf("Введите вектор С\n");
   //VvodVect(C, n);
   //printf("Введите вектор P\n");
   //VvodVect(P, n);
   //printf("Введен вектор С\n");
   //VivodVect(C, n);
   //printf("Введен вектор P\n");
   //VivodVect(P, n);
   //float s = 0.0;

   //s = Sum(C, n);
   //if (Check(P, n, s))
   //{
   //   printf("Условие выполнено\n");
   //   float** A;
   //   FormMatrix(A, C, P, n);
   //   VivodMatrix(A, n);
   //   int i, j;
   //   FindMax(A, n, i, j);
   //   printf("Индексы максимума (%i,%i)", i, j);
   //}

   //else
   //{
   //   printf("Условие не выполнено");
   //}
}