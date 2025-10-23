namespace csharp.training.congruent.classes
{
    using System;
    public readonly struct EvenUInt
    {
        private  readonly uint _value;
        public EvenUInt(uint value)
        {
            if (value % 2 != 0)
                throw new ArgumentException("Only even unsigned integers are allowed.");
            _value = value;
        }
        // Implicit conversion from EvenUInt to uint    
        public static implicit operator uint(EvenUInt even) => even._value;

        // Explicit conversion from uint to EvenUInt    
        public static explicit operator EvenUInt(uint value) => new(value);

        public override string ToString() => _value.ToString();
    }
}

