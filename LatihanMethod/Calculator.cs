using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    public class Calculator
    {
        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        // overload method

        public int Penjumlahan(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        public int Perkalian(int a, int b)
        {
            return a * b;
        }
    }
}
