using System;

namespace Task4
{
    public interface INumber : ICloneable, IComparable<INumber>, IInputOutput
    {
        INumber Add(INumber iNumber);

        INumber Subtract(INumber iNumber);

        INumber Multiply(INumber iNumber);

        INumber Divide(INumber iNumber);
    }
}
