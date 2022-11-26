using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ArithProgression : IChiper
    {
        
        int a;
        int startValue;
        int currentValue;
        public int A
        {
            get => a;
            set => a = value;
        }
        public int GetNext()
        {
            currentValue += A;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
    }
}

