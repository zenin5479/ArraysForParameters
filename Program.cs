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

         Console.ReadKey();
      }

      public static void InputArrayDouble(double[] inputArray, string name)
      {
         Console.WriteLine("Введен вектор {0}:", name);
         int i = 0;
         while (i < inputArray.Length)
         {
            inputArray[i] = inputArray[i];
            //Console.Write("{0:f2} ", inputArray[i]);
            //Console.Write("{0:f} ", inputArray[i]);
            Console.Write("{0} ", inputArray[i]);
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