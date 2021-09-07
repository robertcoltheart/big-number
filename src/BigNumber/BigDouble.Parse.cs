using System;
using System.Globalization;

namespace BigNumber
{
    public partial struct BigDouble
    {
        public static BigDouble Parse(string s)
        {
            throw new NotImplementedException();
        }

        public static BigDouble Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

#if NET5_0_OR_GREATER
        public static BigDouble Parse(ReadOnlySpan<Char> s, IFormatProvider? provider = default)
        {
            throw new NotImplementedException();
        }
#endif

        public static bool TryParse(string? s, out BigDouble result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(string? s, IFormatProvider? provider, out BigDouble result)
        {
            throw new NotImplementedException();
        }

#if NET5_0_OR_GREATER
        public static bool TryParse(ReadOnlySpan<char> s, out BigDouble result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out BigDouble result)
        {
            throw new NotImplementedException();
        }
#endif
    }
}
