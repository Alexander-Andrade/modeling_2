namespace modeling_2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxDistrType = new System.Windows.Forms.ComboBox();
            this.labelDistrType = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_sigma = new System.Windows.Forms.Label();
            this.textBox_sigma = new System.Windows.Forms.TextBox();
            this.label_lambda = new System.Windows.Forms.Label();
            this.textBox_lambda = new System.Windows.Forms.TextBox();
            this.label_eta = new System.Windows.Forms.Label();
            this.textBox_eta = new System.Windows.Forms.TextBox();
            this.label_m = new System.Windows.Forms.Label();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_nRealiz = new System.Windows.Forms.TextBox();
            this.label_nRealiz = new System.Windows.Forms.Label();
            this.label_nInt = new System.Windows.Forms.Label();
            this.textBox_nInt = new System.Windows.Forms.TextBox();
            this.label_mEval = new System.Windows.Forms.Label();
            this.label_dEval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(477, 516);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBoxDistrType
            // 
            this.comboBoxDistrType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDistrType.FormattingEnabled = true;
            this.comboBoxDistrType.Location = new System.Drawing.Point(559, 13);
            this.comboBoxDistrType.Name = "comboBoxDistrType";
            this.comboBoxDistrType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDistrType.TabIndex = 1;
            this.comboBoxDistrType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrType_SelectedIndexChanged);
            // 
            // labelDistrType
            // 
            this.labelDistrType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDistrType.AutoSize = true;
            this.labelDistrType.Location = new System.Drawing.Point(496, 21);
            this.labelDistrType.Name = "labelDistrType";
            this.labelDistrType.Size = new System.Drawing.Size(57, 13);
            this.labelDistrType.TabIndex = 2;
            this.labelDistrType.Text = "distribution";
            // 
            // textBox_a
            // 
            this.textBox_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_a.Location = new System.Drawing.Point(579, 424);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_a.TabIndex = 3;
            // 
            // textBox_b
            // 
            this.textBox_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_b.Location = new System.Drawing.Point(580, 398);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_b.TabIndex = 4;
            // 
            // label_a
            // 
            this.label_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(540, 431);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(13, 13);
            this.label_a.TabIndex = 5;
            this.label_a.Text = "a";
            // 
            // label_b
            // 
            this.label_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(540, 399);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(13, 13);
            this.label_b.TabIndex = 6;
            this.label_b.Text = "b";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(579, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_sigma
            // 
            this.label_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sigma.AutoSize = true;
            this.label_sigma.Location = new System.Drawing.Point(539, 350);
            this.label_sigma.Name = "label_sigma";
            this.label_sigma.Size = new System.Drawing.Size(29, 13);
            this.label_sigma.TabIndex = 9;
            this.label_sigma.Text = "SKO";
            // 
            // textBox_sigma
            // 
            this.textBox_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sigma.Location = new System.Drawing.Point(579, 349);
            this.textBox_sigma.Name = "textBox_sigma";
            this.textBox_sigma.Size = new System.Drawing.Size(100, 20);
            this.textBox_sigma.TabIndex = 8;
            // 
            // label_lambda
            // 
            this.label_lambda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_lambda.AutoSize = true;
            this.label_lambda.Location = new System.Drawing.Point(539, 281);
            this.label_lambda.Name = "label_lambda";
            this.label_lambda.Size = new System.Drawing.Size(41, 13);
            this.label_lambda.TabIndex = 11;
            this.label_lambda.Text = "lambda";
            // 
            // textBox_lambda
            // 
            this.textBox_lambda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_lambda.Location = new System.Drawing.Point(579, 280);
            this.textBox_lambda.Name = "textBox_lambda";
            this.textBox_lambda.Size = new System.Drawing.Size(100, 20);
            this.textBox_lambda.TabIndex = 10;
            // 
            // label_eta
            // 
            this.label_eta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_eta.AutoSize = true;
            this.label_eta.Location = new System.Drawing.Point(539, 255);
            this.label_eta.Name = "label_eta";
            this.label_eta.Size = new System.Drawing.Size(22, 13);
            this.label_eta.TabIndex = 13;
            this.label_eta.Text = "eta";
            // 
            // textBox_eta
            // 
            this.textBox_eta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_eta.Location = new System.Drawing.Point(579, 254);
            this.textBox_eta.Name = "textBox_eta";
            this.textBox_eta.Size = new System.Drawing.Size(100, 20);
            this.textBox_eta.TabIndex = 12;
            // 
            // label_m
            // 
            this.label_m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(539, 324);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(15, 13);
            this.label_m.TabIndex = 15;
            this.label_m.Text = "m";
            // 
            // textBox_m
            // 
            this.textBox_m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_m.Location = new System.Drawing.Point(579, 323);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(100, 20);
            this.textBox_m.TabIndex = 14;
            // 
            // textBox_nRealiz
            // 
            this.textBox_nRealiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nRealiz.Location = new System.Drawing.Point(579, 50);
            this.textBox_nRealiz.Name = "textBox_nRealiz";
            this.textBox_nRealiz.Size = new System.Drawing.Size(100, 20);
            this.textBox_nRealiz.TabIndex = 16;
            // 
            // label_nRealiz
            // 
            this.label_nRealiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nRealiz.AutoSize = true;
            this.label_nRealiz.Location = new System.Drawing.Point(496, 57);
            this.label_nRealiz.Name = "label_nRealiz";
            this.label_nRealiz.Size = new System.Drawing.Size(71, 13);
            this.label_nRealiz.TabIndex = 17;
            this.label_nRealiz.Text = "realization len";
            // 
            // label_nInt
            // 
            this.label_nInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nInt.AutoSize = true;
            this.label_nInt.Location = new System.Drawing.Point(497, 83);
            this.label_nInt.Name = "label_nInt";
            this.label_nInt.Size = new System.Drawing.Size(56, 13);
            this.label_nInt.TabIndex = 19;
            this.label_nInt.Text = "int number";
            // 
            // textBox_nInt
            // 
            this.textBox_nInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nInt.Location = new System.Drawing.Point(580, 76);
            this.textBox_nInt.Name = "textBox_nInt";
            this.textBox_nInt.Size = new System.Drawing.Size(100, 20);
            this.textBox_nInt.TabIndex = 18;
            // 
            // label_mEval
            // 
            this.label_mEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mEval.AutoSize = true;
            this.label_mEval.Location = new System.Drawing.Point(576, 110);
            this.label_mEval.Name = "label_mEval";
            this.label_mEval.Size = new System.Drawing.Size(15, 13);
            this.label_mEval.TabIndex = 20;
            this.label_mEval.Text = "m";
            // 
            // label_dEval
            // 
            this.label_dEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dEval.AutoSize = true;
            this.label_dEval.Location = new System.Drawing.Point(576, 146);
            this.label_dEval.Name = "label_dEval";
            this.label_dEval.Size = new System.Drawing.Size(15, 13);
            this.label_dEval.TabIndex = 21;
            this.label_dEval.Text = "D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 541);
            this.Controls.Add(this.label_dEval);
            this.Controls.Add(this.label_mEval);
            this.Controls.Add(this.label_nInt);
            this.Controls.Add(this.textBox_nInt);
            this.Controls.Add(this.label_nRealiz);
            this.Controls.Add(this.textBox_nRealiz);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.label_eta);
            this.Controls.Add(this.textBox_eta);
            this.Controls.Add(this.label_lambda);
            this.Controls.Add(this.textBox_lambda);
            this.Controls.Add(this.label_sigma);
            this.Controls.Add(this.textBox_sigma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.labelDistrType);
            this.Controls.Add(this.comboBoxDistrType);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxDistrType;
        private System.Windows.Forms.Label labelDistrType;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_sigma;
        private System.Windows.Forms.TextBox textBox_sigma;
        private System.Windows.Forms.Label label_lambda;
        private System.Windows.Forms.TextBox textBox_lambda;
        private System.Windows.Forms.Label label_eta;
        private System.Windows.Forms.TextBox textBox_eta;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.TextBox textBox_nRealiz;
        private System.Windows.Forms.Label label_nRealiz;
        private System.Windows.Forms.Label label_nInt;
        private System.Windows.Forms.TextBox textBox_nInt;
        private System.Windows.Forms.Label label_mEval;
        private System.Windows.Forms.Label label_dEval;
    }
}

