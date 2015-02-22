using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_2
{
    public class Udistribution
    {
        private readonly uint _a;
        private readonly uint _m;
        private uint _Rn;

        public Udistribution(uint a, uint m, uint Ro)
        {
            _a = a;
            _m = m;
            _Rn = Ro;
        }

        public Udistribution()
        {
            _a = 5645;
            _m = 2147483647;
            _Rn = 3594;
        }

        private uint Rn() { return (_a * _Rn) % _m; }
        private double R(uint Rn) { return (double)Rn / (double)_m; }
        virtual public double Random() { return R( _Rn = Rn() ); }

        //оценки мат ожидания и дисперсии

        public static double m(double[] realiz)
        {
            return realiz.Sum() / realiz.Length;
        }
        public static double D(double[] realiz, double m)
        {
            double D = realiz.Sum(x => Math.Pow(x - m, 2));
            return D * ((double)1 / ((double)realiz.Length - (double)1));
        }
        public static double sigma(double[] realiz,double m)
        {
            //СКО
            return Math.Sqrt( D(realiz, m) );
        }
    };
}
