namespace QuebraCofre.Extensions
{
    public static class LongExtensions
    {
        public static int Length(this long value)
        {
            return value.ToString().Length;
        }
    }
}
