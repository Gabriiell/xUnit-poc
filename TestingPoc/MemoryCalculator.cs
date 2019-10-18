using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPoc
{
    public class MemoryCalculator : IDisposable
    {
        public int CurrentValue { get; private set; } = 0;

        public void Add(int a)
        {
            CurrentValue += a;
        }

        public void Divide(int by)
        {
            CurrentValue /= by;
        }

        public void Clear()
        {
            CurrentValue = 0;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}