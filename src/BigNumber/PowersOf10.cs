using System.Globalization;

namespace BigNumber
{
    internal static class PowersOf10
    {
        // The largest exponent that can appear in a Number, though not all mantissas are valid here.
        private const int DoubleExpMax = 308;

        // The smallest exponent that can appear in a Number, though not all mantissas are valid here.
        private const int DoubleExpMin = -324;

        private const int IndexOf0 = -DoubleExpMin - 1;

        private static readonly double[] Powers = new double[DoubleExpMax - DoubleExpMin];

        static PowersOf10()
        {
            for (var i = 0; i < Powers.Length; i++)
            {
                Powers[i] = double.Parse("1e" + (i - IndexOf0), CultureInfo.InvariantCulture);
            }
        }

        public static double Lookup(long power)
        {
            return Powers[IndexOf0 + power];
        }
    }
}
