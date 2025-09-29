using System;

//Массивы в качестве параметров

namespace ArraysForParameters
{
   internal class Program
   {
      static void Main(string[] args)
      {
         string nameArrayOne = "C";
         string nameArrayTwo = "P";
         int size = MethodsForArray.NumberArrayElements();
         double[] vectorC = MethodsForArray.EnterArrayDouble(size, nameArrayOne);
         double[] vectorP = MethodsForArray.EnterArrayDouble(size, nameArrayTwo);
         MethodsForArray.InputArrayDouble(vectorC, nameArrayOne);
         MethodsForArray.InputArrayDouble(vectorP, nameArrayTwo);
         double s = MethodsForArray.Sum(vectorC);
         if (MethodsForArray.Check(vectorP, s))
         {
            Console.WriteLine("Условие выполнено");
            double[,] matrix = MethodsForArray.FormMatrix(vectorC, vectorP);
            MethodsForArray.VivodMatrix(matrix);
            MethodsForArray.FindMax(matrix);
         }
         else
         {
            Console.WriteLine("Условие не выполнено");
         }

         Console.ReadKey();
      }
   }
}