using System;

namespace ArraysForParameters
{
   public class MethodsForArray
   {
      public static void FindMax(double[,] matrix)
      {
         double max = matrix[0, 0];
         int imax = 0;
         int jmax = 0;
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               if (max < matrix[i, j])
               {
                  max = matrix[i, j];
                  imax = i;
                  jmax = j;
               }
            }
         }

         Console.WriteLine("Индексы максимума: [{0},{1}]", imax, jmax);
      }

      public static void OutputMatrix(double[,] matrix)
      {
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               Console.Write("{0:f4} ", matrix[i, j]);
               //Console.Write("{0:f} ", matrix[i, j]);
               //Console.Write("{0} ", matrix[i, j]);
            }

            Console.WriteLine();
         }
      }

      public static double[,] FormMatrix(double[] vectorC, double[] vectorP)
      {
         double[,] z = new double[vectorC.Length, vectorP.Length];
         for (int i = 0; i < vectorC.Length; i++)
         {
            for (int j = 0; j < vectorP.Length; j++)
            {
               z[i, j] = vectorC[i] / (vectorP[j] + vectorC[i] * vectorC[i]);
            }
         }

         return z;
      }

      public static bool Check(double[] vector, double sum)
      {
         int i = 0;
         bool fl = true;
         while (i < vector.Length && fl)
         {
            if (vector[i] < sum)
            {
               i++;
            }
            else
            {
               fl = false;
            }
         }
         return fl;
      }

      public static double Sum(double[] vector)
      {
         double s = 0.0;
         int i = 0;
         while (i < vector.Length)
         {
            s += vector[i];
            i++;
         }

         return s;
      }

      public static void InputArrayDouble(double[] vector, string name)
      {
         Console.WriteLine("Введен вектор {0}:", name);
         int i = 0;
         while (i < vector.Length)
         {
            vector[i] = vector[i];
            //Console.Write("{0:f2} ", vector[i]);
            //Console.Write("{0:f} ", vector[i]);
            Console.Write("{0} ", vector[i]);
            i++;
         }

         Console.WriteLine();
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
}