using System;

namespace Task4
{
    interface INumber : ICloneable, IComparable<INumber>
    {
        INumber Add(INumber iNumber);

        INumber Subtract(INumber iNumber);

        INumber Multiply(INumber iNumber);

        INumber Divide(INumber iNumber);
    }
}
