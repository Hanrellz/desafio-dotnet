namespace QuebraCofre.Services
{
    public class FibonacciService
    {
        public long CalculoBase(long n)
        {
            long a = 0;
            long b = 1;

            while (n-- > 1)
            {
                long t = a;
                a = b;
                b += t;
            }
            return b;
        }
    }
}