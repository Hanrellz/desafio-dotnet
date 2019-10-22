using System;
using Mouts.Business;
using Mouts.Metadata;
using System.Linq;

namespace Mouts.App
{
    class Program
    {
        private const byte TIP = 1;
        private const byte FIBONACCI_VALUE = 2;
        static void Main(string[] args)
        {
            byte operationType = GetOperationType();

            Safebox safebox = new Safebox(16, 7);

            try
            {
                while (!safebox.IsOpen())
                {
                    safebox.EnsureTimer();
                    Console.WriteLine("Enter safebox's value " + (safebox.Codes.Count + 1));
                    string value = Console.ReadLine();

                    if (!long.TryParse(value, out long safeboxValue))
                        throw new ArgumentException("Only numbers are allowed in safebox's tip.");

                    string code = operationType == TIP ?
                                                Fibonacci.GetValueFromIndex((int)safeboxValue).ToString() :
                                                Fibonacci.GetIndexFromValue(safeboxValue).ToString();

                    safebox.AddCode(code);
                    Console.WriteLine("The next code is " + safebox.Codes.LastOrDefault());
                }

                Console.Write("SAFEBOX IS OPEN!!!!!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private static byte GetOperationType()
        {
            Console.WriteLine("Select the input type.");
            Console.WriteLine("1 - Tip number");
            Console.WriteLine("2 - Fibonacci value number");

            if (byte.TryParse(Console.ReadLine(), out byte selectedValue) && (new byte[] { 1, 2 }).Contains(selectedValue))
                return selectedValue;
            else
            {
                Console.WriteLine("Invalid option!");
                return GetOperationType();
            }
        }
    }
}
