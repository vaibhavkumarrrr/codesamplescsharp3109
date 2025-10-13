namespace csharp.training.congruent.classes
{
    using System;
    public struct EvenUInt
    {
        private readonly uint _value;
        public uint Value => _value;
        public EvenUInt(uint value)
        {
            if (value % 2 != 0)
                throw new ArgumentException("Only even unsigned integers are allowed.");
            _value = value;
        }
        // Implicit conversion from EvenUInt to uint    
        public static implicit operator uint(EvenUInt even) => even._value;

        // Explicit conversion from uint to EvenUInt    
        public static explicit operator EvenUInt(uint value) => new EvenUInt(value);

        public override string ToString() => _value.ToString();

    }
}

