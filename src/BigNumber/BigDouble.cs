using System;

namespace BigNumber
{
    [Serializable]
    public partial struct BigDouble : IEquatable<BigDouble>, IComparable<BigDouble>, IComparable, IFormattable
    {
        public BigDouble(int value)
        {
        }

        [CLSCompliant(false)]
        public BigDouble(uint value)
        {
        }

        public BigDouble(double value)
        {
        }

        [CLSCompliant(false)]
        public BigDouble(byte[] value)
        {
        }

        public BigDouble(ReadOnlySpan<byte> value)
        {
        }

        public static implicit operator BigDouble(double value)
        {
            return new(value);
        }

        public bool Equals(BigDouble other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public int CompareTo(BigDouble other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string ToString(string? format)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
