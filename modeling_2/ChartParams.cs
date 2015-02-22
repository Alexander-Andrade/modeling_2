using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_2
{
    class ChartParams
    {
        //размер реализации
        public uint nRealiz { private set; get; }
        // кол-во диапазонов разбиения реализации
        public uint nInt { private set; get; }

        public ChartParams(uint nRealiz,uint nInt)
        {
            this.nRealiz = nRealiz;
            this.nInt = nInt;
        }
        public ChartParams()
        {
            nRealiz = 10000;
            nInt = 20;
        }
        //массив реализаций
        public double[] realizationArray(Udistribution dist)
        {
            double[] realiz = new double[nRealiz];
            for (uint i = 0; i < nRealiz; i++)
                realiz[i] = dist.Random();
            return realiz;
        }
        public static double variationRange(double[] realiz)
        {//диапазон варьирования
            return realiz.Max() - realiz.Min();
        }
        public double delta(double[] realiz)
        {//длина интервала
            return variationRange(realiz) / (double)nInt;
        }

        public double[] intBorders(double[] realiz)
        {
            //границы интервалов
            double[] borders = new double[nInt + 1];
            //самая левая гран
            double b = realiz.Min();
            borders[0] = b;
            double d = delta(realiz);
            // граничные знач для каждого i-го инт
            for (uint i = 1; i <= nInt; i++)
                borders[i] = borders[i - 1] + d;
            return borders;
        }
        public double[] bordersMiddle(double[] borders)
        {//середины инт-ов для гисторгаммы, ось X
            double[] mid = new double[nInt];
            for (uint i = 0; i < nInt; i++)
                mid[i] = (borders[i] + borders[i + 1]) / 2;
            return mid;
        }
        public uint[] hitArray(double[] realiz, double[] borders)
        {//кол-во попаданий в i-ый интервал
            uint[] hitsArr = new uint[nInt];
            for (uint i = 0; i < nInt; i++)
            {
                foreach (var el in realiz)
                {
                    if (el >= borders[i] && el < borders[i + 1])
                        hitsArr[i]++;
                }
            }
            return hitsArr;
        }
        public double[] hitsOrdinates(uint[] hitArr)
        { // ординаты гистограммы распределения
            double[] hitsOrd = new double[nInt];
            for (uint i = 0; i < nInt; i++)
                hitsOrd[i] = (double)hitArr[i] / (double)nRealiz;
            return hitsOrd;
        }
    }
}
