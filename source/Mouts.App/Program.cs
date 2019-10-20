using System;
using Mouts.Business;
using Mouts.Metadata;
using System.Linq;

namespace Mouts.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Safebox safebox = new Safebox(3, 2);

            try
            {
                while (!safebox.IsOpen())
                {
                    safebox.EnsureTimer();
                    Console.WriteLine("Enter safebox's tip " + (safebox.Codes.Count + 1));
                    string tip = Console.ReadLine();

                    if(!int.TryParse(tip, out int safeboxTip))
                        throw new ArgumentException("Only numbers are allowed in safebox's tip.");    

                    string code = Fibonacci.GetValueFromIndex(safeboxTip).ToString();

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
    }
}
