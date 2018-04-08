using System;

namespace Task4
{
    class ComplexNumber : INumber, IInputOutput
    {
        private double real;

        private double imaginary;

        public double Real
        {
            get
            {
                return real;
            }
            private set
            {
                real = value;
            }
        }

        public double Imaginary
        {
            get
            {
                return imaginary;
            }
            private set
            {
                imaginary = value;
            }
        }

        public ComplexNumber()
        {
            Real = 0.0;
            Imaginary = 0.0;
        }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public INumber Add(INumber iNumber)
        {
            ComplexNumber second = iNumber as ComplexNumber;
            return new ComplexNumber(Real + second.Real, Imaginary + second.Imaginary);
        }

        public object Clone()
        {
            return new ComplexNumber(Real, Imaginary);
        }

        public int CompareTo(INumber other)
        {
            ComplexNumber second = other as ComplexNumber;
            if(Real == second.Real && Imaginary == second.Imaginary)
            {
                return 0;
            }
            throw new Exception("The notion of 'more' and 'less' for complex numbers makes no sense");
        }

        private ComplexNumber ComplexСonjugate()
        {
            return new ComplexNumber(Real, -Imaginary);
        }
        
        public INumber Divide(INumber other)
        {
            //a+bi
            //c+di
            // (a+bi)*(conj)/((c+bi)*conj);
            INumber first = this;
            ComplexNumber second = other as ComplexNumber;
            INumber conjugatedDenominator = second.ComplexСonjugate();
            second = (ComplexNumber) second.Multiply(conjugatedDenominator);
            first = first.Multiply(conjugatedDenominator).Multiply(new RealNumber(second.Real));
            return first;
        }

        public void FormatInput()
        {
            Console.WriteLine("Enter real part: ");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter imaginary part: ");
            double i = Double.Parse(Console.ReadLine());
            Real = r;
            Imaginary = i;
        }

        public void FormatOutput()
        {
            Console.WriteLine("Complex number: {0}", this.ToString());
        }

        public INumber Multiply(INumber iNumber)
        {
            //a+bi
            //c+di
            //(ac - bd) + (ad + bc)i
            ComplexNumber second = iNumber as ComplexNumber;
            return new ComplexNumber(Real * second.Real - Imaginary * second.Imaginary, Real * second.Imaginary + Imaginary * second.Real);
        }

        public INumber Subtract(INumber iNumber)
        {
            ComplexNumber second = iNumber as ComplexNumber;
            return new ComplexNumber(Real - second.Real, Imaginary - second.Imaginary);
        }

        public override string ToString()
        {
            string number = Real.ToString();
            if (Imaginary >= 0)
            {
                number += "+";
            }
            number += Imaginary.ToString() + "i";
            return number;
        }
    }
}
