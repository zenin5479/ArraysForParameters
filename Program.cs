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
         InputArrayDouble(vectorC, nameArrayOne);
         InputArrayDouble(vectorP, nameArrayTwo);
         double s = Sum(vectorC);
         if (Check(vectorP, s))
         {
            Console.WriteLine("Условие выполнено");
            double[,] hj = FormMatrix(vectorC, vectorP);
         }
         else
         {
            Console.WriteLine("Условие не выполнено");
         }

         Console.ReadKey();

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

      void VivodMatrix(float** x, int nx)
      {
         for (int i = 0; i < nx; i++)
         {
            for (int j = 0; j < nx; j++)
            {
               printf("%f ", x[i][j]);
            }
            printf("\n");
         }
      }


      public static double[,] FormMatrix(double[] x, double[] y)
      {
         double[,] z = new double[x.Length, x.Length];
         for (int i = 0; i < x.Length; i++)
         {
            for (int j = 0; j < x.Length; j++)
            {
               z[i, j] = x[i] / (y[j] + x[i] * x[i]);
            }
         }

         return z;
      }

      //void FormMatrix(float**& z, float* x, float* y, int nx)
      //{
      //   z = new float*[nx];
      //   for (int i = 0; i < nx; i++)
      //   {
      //      z[i] = new float[nx];
      //      for (int j = 0; j < nx; j++)
      //      {
      //         z[i][j] = x[i] / (y[j] + x[i] * x[i]);
      //      }
      //   }
      //}

      //void VivodMatrix(float** x, int nx)
      //{
      //   for (int i = 0; i < nx; i++)
      //   {
      //      for (int j = 0; j < nx; j++)
      //      {
      //         printf("%f ", x[i][j]);
      //      }
      //      printf("\n");
      //   }
      //}

      //void FindMax(float** z, int nx, int& imax, int& jmax)
      //{
      //   float Max = z[0][0];
      //   imax = 0;
      //   jmax = 0;
      //   for (int i = 0; i < nx; i++)
      //   {
      //      for (int j = 0; j < nx; j++)
      //      {
      //         if (Max < z[i][j])
      //         {
      //            Max = z[i][j];
      //            imax = i;
      //            jmax = j;
      //         }
      //      }
      //   }
      //}

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