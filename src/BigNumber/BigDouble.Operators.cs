namespace BigNumber
{
    public partial struct BigDouble
    {
        public static BigDouble operator +(BigDouble left, BigDouble right)
        {
            return Add(left, right);
        }

        public static BigDouble operator +(BigDouble left, double right)
        {
            return Add(left, new BigDouble(right));
        }

        public static BigDouble operator +(double left, BigDouble right)
        {
            return Add(new BigDouble(left), right);
        }
    }
}
