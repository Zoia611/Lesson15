using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GeometrProgression : IChiper
    {
        int b;
        int startValue;
        int currentValue;
        public int B
        {
            get => b;
            set => b = value;
        }
        public int GetNext()
        {
            currentValue *= B;
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
