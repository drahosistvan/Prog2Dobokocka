using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobokocka
{
    internal class Diece
    {
        private int minValue = 1;
        private int maxValue = 6;

        public int roll()
        {
            return new Random().Next(minValue, maxValue);
        }
    }
}
