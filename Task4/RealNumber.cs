using System;

namespace Task4
{
    class RealNumber : INumber, IInputOutput
    {
        private double number;

        public double Number
        {
            get
            {
                return number;
            }
            private set
            {
                number = value;
            }
        }

        public RealNumber()
        {
            Number = 0.0;
        }

        public RealNumber(double n)
        {
            Number = n;
        }

        public INumber Add(INumber iNumber)
        {
            RealNumber second = iNumber as RealNumber;
            return new RealNumber(Number + second.Number);
        }

        public object Clone()
        {
            return new RealNumber(number);
        }

        public int CompareTo(INumber other)
        {
            RealNumber second = other as RealNumber;
            if (Number > second.Number)
            {
                return 1;
            }
            else if (Number < second.Number)
            {
                return -1;
            }
            return 0;
        }

        public INumber Divide(INumber iNumber)
        {
            RealNumber second = iNumber as RealNumber;
            return new RealNumber(Number / second.Number);
        }

        public void FormatInput()
        {
            Console.WriteLine("Enter real number: ");
            double n = Double.Parse(Console.ReadLine());
            Number = n;
        }

        public void FormatOutput()
        {
            Console.WriteLine("Real number: {0}", Number);
        }

        public INumber Multiply(INumber iNumber)
        {
            RealNumber second = iNumber as RealNumber;
            return new RealNumber(Number * second.Number);
        }

        public INumber Subtract(INumber iNumber)
        {
            RealNumber second = iNumber as RealNumber;
            return new RealNumber(Number - second.Number);
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}