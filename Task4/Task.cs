using System;

namespace Task4
{
    public class Task
    {
        public INumber Sum(INumber[] arrayNumbers)
        {
            INumber res = arrayNumbers[0];
            for (var i = 1; i < arrayNumbers.Length; ++i)
            {
                res = res.Add(arrayNumbers[i]);
            }

            return res;
        }

        public INumber Product(INumber[] arrayNumbers)
        {
            INumber res = arrayNumbers[0];
            for (var i = 1; i < arrayNumbers.Length; ++i)
            {
                res.Multiply(arrayNumbers[i]);
            }

            return res;
        }

        public INumber ArithmeticMean(INumber[] arrayNumbers)
        {
            INumber res = Product(arrayNumbers);
            res.Divide(new RealNumber(arrayNumbers.Length));
            return res;
        }
        
    }
}
