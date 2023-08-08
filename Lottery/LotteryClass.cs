using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class LotteryClass
    {
        private int _maxValue;
        private int _wantedNumbers;
        private List<int> _drawnNumbers;
        private Random _random;

        public LotteryClass(int maxValue, int wantedNumbers)
        {
            _maxValue = maxValue;
            _wantedNumbers = wantedNumbers;
            _drawnNumbers = new List<int>();
            _random = new Random();
        }

        public int[] DrawAllNumbers()
        {
            while (_drawnNumbers.Count < _wantedNumbers)
            {
                DrawNextNumber();
            }

            return _drawnNumbers.ToArray();
        }

        public int DrawNextNumber()
        {
            if (IsLotteryFinished())
            {
                throw new InvalidOperationException("Lottery is finished");
            }

            int nextNumber;
            do
            {
                nextNumber = _random.Next(1, _maxValue + 1);
            } while (_drawnNumbers.Contains(nextNumber));

            _drawnNumbers.Add(nextNumber);
            return nextNumber;
        }

        public bool IsLotteryFinished()
        {
            return _drawnNumbers.Count >= _wantedNumbers;
        }
    }
}
