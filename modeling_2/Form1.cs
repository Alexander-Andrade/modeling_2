using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeling_2
{
    public partial class Form1 : Form
    {
        //список имён распределений (отображается в combobox)
        private List<string> dList;
        //перечисление распределений
        enum Distributions { uniform, gaussian, exponential, gamma, triangular, simpson };
        //параметры вводимые в textbox-ы
        enum Params { a, b, m, sigma, eta, lambda, nInt, nRealiz };

        //ассоц массив для методов отображ параметров определённого распредел
        public delegate void showParams();
        private Dictionary<Distributions, showParams> showDist;
  
        // методы и параметры для тестирования распределений
        private ChartParams chartParams;

        public Form1()
        {
            InitializeComponent();

            //заполнить список имён распределений
            dList = new List<string>();
            addDistributionsToList(dList);

           
            showDist = new Dictionary<Distributions, showParams>();
            addToshowDistionary(showDist);

            //заполнить combobox вариантами распределений
            comboBoxDistrType.Items.AddRange(dList.ToArray());

            chartParams = new ChartParams();
        }
       
        void addDistributionsToList(List<string> dList)
        {//виды обрабатываемых распределений
            dList.Add("uniform distribution");
            dList.Add("gaussian distribution");
            dList.Add("exponential distribution");
            dList.Add("gamma distribution");
            dList.Add("triangular distribution");
            dList.Add("simpson distribution");
        }

        public Udistribution selectDistr(Dictionary<string, double> pVal)
        {//в зависимости от выбранного пункта combobox, работаем с определ распред
            switch(comboBoxDistrType.SelectedIndex)
            {
                case (int)Distributions.uniform :
                    return new UniformDist(pVal[textBox_a.Name], pVal[textBox_b.Name]);
                case (int)Distributions.gaussian :
                    return new GaussianDist(pVal[textBox_m.Name], pVal[textBox_sigma.Name]);
                case (int)Distributions.exponential :
                    return new ExponentialDist(pVal[textBox_lambda.Name]);
                case (int)Distributions.gamma :
                    return new GammaDist(pVal[textBox_eta.Name], pVal[textBox_lambda.Name]);
                case (int)Distributions.triangular :
                    return new TriangularDist(pVal[textBox_a.Name], pVal[textBox_b.Name]);
                case (int)Distributions.simpson :
                    return new SimpsonDist(pVal[textBox_a.Name], pVal[textBox_b.Name]);
                default :
                    return new Udistribution();
            }
        }
        void addToshowDistionary(Dictionary<Distributions, showParams> showDist)
        {//параметры отображать для 1 распредел
            showDist.Add(Distributions.uniform, showUniformParams);
            showDist.Add(Distributions.gaussian, showGaussianParams);
            showDist.Add(Distributions.exponential, showExponentialParams);
            showDist.Add(Distributions.gamma, showGammaParams);
            showDist.Add(Distributions.triangular, showTriangularParams);
            showDist.Add(Distributions.simpson, showSimpsonParams);
        }
        // отображение вводимых параметров распределений
        void hideAllParams()
        {
            label_a.Hide();
            textBox_a.Hide();

            label_b.Hide();
            textBox_b.Hide();


            label_sigma.Hide();
            textBox_sigma.Hide();

            label_m.Hide();
            textBox_m.Hide();


            label_eta.Hide();
            textBox_eta.Hide();

            label_lambda.Hide();
            textBox_lambda.Hide();
        }

        void showUniformParams()
        {     
            label_a.Show();
            textBox_a.Show();

            label_b.Show();
            textBox_b.Show();
        }
        void showGaussianParams()
        {
            label_sigma.Show();
            textBox_sigma.Show();

            label_m.Show();
            textBox_m.Show();
        }

        void showExponentialParams()
        {
            label_lambda.Show();
            textBox_lambda.Show();
        }

        void showGammaParams()
        {
            label_lambda.Show();
            textBox_lambda.Show();

            label_eta.Show();
            textBox_eta.Show();
        }

        void showTriangularParams()
        {
            showUniformParams();
        }

        void showSimpsonParams()
        {
            showUniformParams();
        }
        //считывание вводимых парам-ов и запись в ассоциативный массив
        Dictionary<string,double> readParams()
        {//чтение textbox
            Dictionary<string, double> dict = new Dictionary<string, double>();
           
                foreach(TextBox tb in this.Controls.OfType<TextBox>())
                    if(tb.Visible == true)
                        dict.Add(tb.Name, Convert.ToDouble(tb.Text));
            return dict;
        }
        

        void changeSelectedParams(int index)
        {   // отображение параметров распределения для их ввода  
            hideAllParams();
            // вывести парам равномерного распред
            showDist[(Distributions)index]();
        }
        void showDistrEvals(double[] realiz)
        {
            //вывод оценок распределения
            double m = UniformDist.m(realiz);
            double D = UniformDist.D(realiz, m);
            label_dEval.Text = "D: " + D.ToString();
            label_mEval.Text = "m: " + m.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Dictionary<string, double> pVal = readParams();
                chartParams = new ChartParams((uint)pVal[textBox_nRealiz.Name], (uint)pVal[textBox_nInt.Name]);

                Udistribution dist = selectDistr(pVal);
                //массив реализаций
                double[] realiz = chartParams.realizationArray(dist);
                //вывод оценок распределения
                showDistrEvals(realiz);

                double[] borders = chartParams.intBorders(realiz);
                //кол-во попаданий в каждый инт
                uint[] hitsArr = chartParams.hitArray(realiz, borders);
                //частота попаданий,ордината гистограммы
                double[] freq = chartParams.hitsOrdinates(hitsArr);
                //вычисл середины инт-ов для оси x
                double[] mid = chartParams.bordersMiddle(borders);

                this.chart1.Series["Series1"].Points.DataBindXY(mid, freq);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBoxDistrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //вывести на экран параметры выбранного распределения
            changeSelectedParams(comboBoxDistrType.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //по умолчанию
            textBox_nInt.Text = chartParams.nInt.ToString();
            textBox_nRealiz.Text = chartParams.nRealiz.ToString();

            //вывести 1 распрееление
            comboBoxDistrType.SelectedIndex = 0;

            hideAllParams();
            //вывести парам равномерного распред
            showDist[Distributions.uniform]();
        }
    }
}
