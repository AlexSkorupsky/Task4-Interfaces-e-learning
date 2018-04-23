using System;
using Task4;
using NUnit.Framework;

namespace TaskUnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestRealNumberAdd()
        {
            RealNumber a = new RealNumber(5);
            RealNumber b = new RealNumber(15);
            RealNumber c = new RealNumber(20);
            a = a.Add(b) as RealNumber;
            Assert.True(a.CompareTo(c) == 0);
        }

        [Test]
        public void TestRealNumberDivide()
        {
            RealNumber a = new RealNumber(50);
            RealNumber b = new RealNumber(10);
            RealNumber c = new RealNumber(5);
            a = a.Divide(b) as RealNumber;
            Assert.True(a.CompareTo(c) == 0);
        }
        
        [Test]
        public void TestRealNumberMultiply()
        {
            RealNumber a = new RealNumber(5);
            RealNumber b = new RealNumber(10);
            RealNumber c = new RealNumber(50);
            b = b.Multiply(a) as RealNumber;
            Assert.True(b.CompareTo(c) == 0);
        }

        [Test]
        public void TestRealNumberSubstract()
        {
            RealNumber a = new RealNumber(5);
            RealNumber b = new RealNumber(15);
            RealNumber c = new RealNumber(10);
            b = b.Subtract(a) as RealNumber;
            Assert.True(b.CompareTo(c) == 0);
        }
        
        [Test]
        public void TestRealNumberClone()
        {
            RealNumber a = new RealNumber(5);
            RealNumber b = a.Clone() as RealNumber;
            Assert.True(b.CompareTo(a) == 0);
        }
        
        [Test]
        public void TestRealNumberToString()
        {
            RealNumber a = new RealNumber(5);
            Assert.True(a.ToString() == "5");
        }
        
        [Test]
        public void TestComplexNumberAdd()
        {
            ComplexNumber a = new ComplexNumber(5, 2);
            ComplexNumber b = new ComplexNumber(15, 3);
            ComplexNumber c = new ComplexNumber(20, 5);
            a = a.Add(b) as ComplexNumber;
            Assert.True(a.CompareTo(c) == 0);
        }
        
        [Test]
        public void TestComplexNumberMultiply()
        {
            ComplexNumber a = new ComplexNumber(5, 2);
            ComplexNumber b = new ComplexNumber(15, 3);
            ComplexNumber c = new ComplexNumber(69, 45);
            a = a.Multiply(b) as ComplexNumber;
            Assert.True(a.CompareTo(c) == 0);
        }

        [Test]
        public void TestComplexNumberSubstract()
        {
            ComplexNumber a = new ComplexNumber(5, 2);
            ComplexNumber b = new ComplexNumber(15, 3);
            ComplexNumber c = new ComplexNumber(10, 1);
            b = b.Subtract(a) as ComplexNumber;
            Assert.True(b.CompareTo(c) == 0);
        }
        
        [Test]
        public void TestComplexNumberClone()
        {
            ComplexNumber a = new ComplexNumber(5, 1);
            ComplexNumber b = a.Clone() as ComplexNumber;
            Assert.True(b.CompareTo(a) == 0);
        }
        
        [Test]
        public void TestComplexNumberToString()
        {
            ComplexNumber a = new ComplexNumber(5, 2);
            Assert.True(a.ToString() == "5+2i");
        }
        
        [Test]
        public void TestTaskSumOfReal()
        {
            Task obj = new Task();
            RealNumber[] arrReal = new RealNumber[2];
            arrReal[0] = new RealNumber(10);
            arrReal[1] = new RealNumber(17);
            var real = new RealNumber(27);
            var res = obj.Sum(arrReal) as RealNumber;
            Assert.True(res.CompareTo(real) == 0);
        }
        
        [Test]
        public void TestTaskSumOfComplex()
        {
            Task obj = new Task();
            ComplexNumber[] arrComplex = new ComplexNumber[2];
            arrComplex[0] = new ComplexNumber(10, 2);
            arrComplex[1] = new ComplexNumber(17, 4);
            var complex = new ComplexNumber(27, 6) as ComplexNumber;
            var res = obj.Sum(arrComplex) as ComplexNumber;
            Assert.True(res.CompareTo(complex) == 0);
        }
       
    }
}
