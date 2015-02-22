using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_2
{
    public class UniformDist : Udistribution
    {//равномерное 
        private readonly double _a;
        private readonly double _b;
        //равномерное распред 0..1

       public  UniformDist (double a,double b) : base()
        {
            _a = a;
            _b = b;

        }

        public UniformDist () { }

        public override double Random()
        {
            return _a + (_b - _a) * base.Random();
        }

        double Random(double a, double b)
        {
            return a + (b - a) * base.Random();
        }
        
        public double m()
        {
            return (_a + _b) / 2;
        }
        public double D()
        {
            return Math.Pow((_b - _a), 2) / 12;
        }
    };

    public class GaussianDist : Udistribution
    {
        //число суммируемых СВ
        private readonly uint _n;
        private readonly double _m;
        private readonly double _sigma;
       public  GaussianDist(double m,double sigma,uint n){_m = m;_sigma = sigma;_n = n;}
        public GaussianDist(double m,double sigma){_m = m;_sigma = sigma;_n = 8;}


        public override double Random()
        {
            double sum = 0;
            for (uint i = 0; i < _n; i++)
                sum += base.Random();
            return _m + _sigma * Math.Sqrt(12 / _n) * (sum - _n / 2);
        }

        public double m() { return _m; }
        public double D() { return Math.Pow(_sigma, 2); }
    };

    public class ExponentialDist : Udistribution
    {
        private readonly double _lambda;

        public ExponentialDist(double lambda)
        {
            _lambda = lambda;
        }
        public override double Random()
        {
            return (-1 / _lambda) * Math.Log(base.Random());
        }
        public double m(){ return 1 / _lambda; }
        public double D() { return 1 / Math.Pow(_lambda, 2); }
    };

    public class GammaDist : Udistribution
    {
        private readonly double _eta;
        private readonly double _lambda;

        public GammaDist(double eta,double lambda)
        {
            _eta = eta;
            _lambda = lambda;
        }

        public override double Random()
        {
            double mul = 1;
            for (uint i = 0; i < _eta; i++)
                mul *= base.Random();
            return (-1 / _lambda) * Math.Log(mul);
        }

        public double m() { return _eta / _lambda; }
        public double D() { return _eta / Math.Pow(_lambda, 2); }
        
    };

    public class TriangularDist : Udistribution
    {
        private readonly double _a;
        private readonly double _b;


        public TriangularDist(double a,double b)
        {
            _a = a;
            _b = b;
        }

        public override double Random()
        {
            return _a + (_b - _a) * Math.Max(base.Random(), base.Random());
        }

    };

    public class SimpsonDist : UniformDist
    {
        public SimpsonDist(double a,double b) :  base(a/2, b/2) {}

        public override double Random() 
        {
            return base.Random() + base.Random();
        }
    };
}
