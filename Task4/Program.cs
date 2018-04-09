using System;

namespace Task4
{
    class Program
    {
        public enum TypeNumber { Real, Complex };
        
        static void Main(string[] args)
        {    
            var arrReal = new RealNumber[2];
            InputArr(arrReal, TypeNumber.Real);
            OutputArr(arrReal);
            var arrComplex = new ComplexNumber[2];
            InputArr(arrComplex, TypeNumber.Complex);
            OutputArr(arrComplex);
            CheckResults(arrReal, TypeNumber.Real);
            CheckResults(arrComplex, TypeNumber.Complex);
            OutputSortClonedNumbers();
            Console.ReadKey();
        }

        public static void InputArr(INumber[] arr, TypeNumber type)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                if (type == TypeNumber.Real)
                {
                    arr[i] = new RealNumber();
                }
                else
                {
                    arr[i] = new ComplexNumber();
                }
                arr[i].FormatInput();
            }
        }

        public static void OutputArr(INumber[] arr)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                arr[i].FormatInput();
            }
        }
        
        public static void CheckResults(INumber[] arr, TypeNumber type)
        {
            TypeNumber data;
            if (type == TypeNumber.Real)
            {
                data = TypeNumber.Real;
            }
            else
            {
                data = TypeNumber.Complex;
            }
            Task obj = new Task();
            Console.WriteLine("Sum of {0}: {1}", data,obj.Sum(arr));
            Console.WriteLine("Product of {0}: {1}", data, obj.Product(arr));
            Console.WriteLine("Arithmetical mean of {0}: {1}", data, obj.ArithmeticMean(arr));
        }
        
        public static void OutputSortClonedNumbers()
        {
            RealNumber[] arr = new RealNumber[10];
            for (var i = 0; i < 10; ++i)
            {
                arr[i] = new RealNumber(i*i-2*i-4);
            }
            RealNumber[] arr2 = (RealNumber[]) arr.Clone();
            Array.Sort(arr2);

            Console.WriteLine("Sorted cloned array: ");
            foreach (var it in arr2)
            {
                it.FormatOutput();
            }
        }
    }
}
