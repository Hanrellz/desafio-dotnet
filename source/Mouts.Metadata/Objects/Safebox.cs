using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;

namespace Mouts.Metadata
{
    public class Safebox
    {
        private Alarm alarm;
        public byte CodeLenght { get; private set; }
        public byte CodeQuantity { get; set; }
        public IList<string> Codes { get; private set; }
        public int CodeDigitationIntervalSeconds { get; set; }

        public Safebox(byte codeLenght, byte codeQuantity, int codeDigitationIntervalSeconds = 3)
        {
            CodeLenght = codeLenght;
            CodeQuantity = codeQuantity;
            Codes = new List<string>(codeQuantity);
            CodeDigitationIntervalSeconds = codeDigitationIntervalSeconds;
            alarm = new Alarm(1000, codeDigitationIntervalSeconds);
        }
        public bool IsOpen() => Codes.Count == CodeQuantity;
        public void AddCode(string code)
        {
            code = EnsureCode(code);

            if (!long.TryParse(code, out long convertedCode))
                throw new ArgumentException("Only numbers are allowed in safebox's code.");

            Codes.Add(code);

            alarm.Stop();
        }

        private string EnsureCode(string code)
        {
            if (code.Length < CodeLenght)
                return code.PadLeft(CodeLenght, '0');
            else
                return code.Substring(0, CodeLenght);
        }

        public void EnsureTimer() => alarm.Reset();
    }
}
