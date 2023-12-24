﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BelovaEA.Sprint7.Project.V13.Lib;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    public partial class FormEconomy : Form
    {
        public FormEconomy()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void comboBoxChoosingCountry_BEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\VVP.csv";
            int index = comboBoxChoosingCountry_BEA.SelectedIndex;

            double[,] matrixVVP = ds.Economy(index, path);

            // Настраиваем оси
            chartVVP_BEA.ChartAreas[0].AxisX.Title = "Годы";
            chartVVP_BEA.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft Sans Serif", 13);
            chartVVP_BEA.ChartAreas[0].AxisY.Title = "млрд. долл. США";
            chartVVP_BEA.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft Sans Serif", 13);

            // Заполняем диаграмму
            chartVVP_BEA.Series[0].Points.Clear();
            for (int r = 0; r < matrixVVP.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrixVVP.GetLongLength(1); c++)
                {
                    chartVVP_BEA.Series[0].Points.AddXY(matrixVVP[0, c], matrixVVP[1, c]);
                }
            }

            // заполняем textbox
            switch (index)
            {
                case 0:
                    textBoxEconomy_BEA.Text = "Экономика России занимает 5-е место среди стран мира и 1-е среди стран Европы по объёму ВВП по ППС, который на 2023 год оценивался в 5,51 трлн долларов (по данным МВФ). По объёму номинального ВВП (2,215 трлн долларов в 2022 году) Россия занимала 8-е место в мире и 4-е в Европе (по данным МВФ). По ВВП на душу населения (ППС) в 2022 году Россия была на 59-м месте в мире (МВФ). По ВВП на душу населения номинальному в 2022 году Россия была на 63-м месте в мире (МВФ). Экономика России является смешанной и относится к переходному типу.\r\nВ настоящее время промышленность России включает следующие конкурентоспособные отрасли: нефтяная и газовая, добыча, переработка драгоценных камней и металлов, самолетостроение, ракетно - космическое производство, атомная промышленность, производство вооружения и военной техники, электротехника, целлюлозно-бумажная промышленность, автомобильная промышленность, транспортное, дорожное и с.-х.машиностроение, легкая и пищевая промышленность.";
                    break;
                case 1:
                    textBoxEconomy_BEA.Text = "Экономика США — первая экономика мира по номинальному ВВП. По паритету покупательской способности, однако, США с долей около 15 % от общемирового ВВП уступили первое место экономике КНР в 2014 году.Структура экономики США отличается ярко выраженной постиндустриальностью. Около 80 % американского ВВП создаётся в отраслях сферы услуг (куда относятся, прежде всего, здравоохранение, финансы, торговля, различные профессиональные и личные услуги, транспорт и связь, услуги государственных учреждений, наука и образование). На долю материального производства (сельское хозяйство, лесное хозяйство и рыбная промышленность, добывающая и обрабатывающая промышленность, строительство), таким образом, остаётся менее 20 % ВВП, в том числе 1 % в сельском хозяйстве и 18 % в промышленности.";
                    break;
                case 2:
                    textBoxEconomy_BEA.Text = "Экономика Франции — развитая экономика страны-члена Евросоюза. ВВП на душу населения по ППС в 2022 году составлял 102 % от среднего уровня по Евросоюзу, в то время как номинальный ВВП на душу населения — 114,72 %. Франция — высокоразвитая страна, ядерная и космическая держава. По общему объёму экономики страна занимает второе место в Европейском союзе (после Германии) и стабильно входит в первую мировую десятку (в 2019 году Франция признана 6-й экономически развитой державой мира после США, Китая, Японии, Германии и Индии).\r\nТем не менее, после вступления в Еврозону, базовые экономические показатели страны демонстрируют тенденцию к ухудшению. Серьёзной проблемой Франции является также и продолжающийся интенсивный рост населения, который в несколько раз превышает темпы ростa ВВП страны в 2000 - е годы.\r\nОсновными отраслями промышленности являются машиностроительная, химическая, автомобилестроительная, аэрокосмическая, электронная, пищевая, горнодобывающая, металлургическая, атомная энергетика, производство одежды.";
                    break;
                case 3:
                    textBoxEconomy_BEA.Text = "Экономика Китайской Народной Республики (КНР) — вторая, после США, экономика мира по номинальному ВВП, первая — по ВВП по паритету покупательной способности (с 2014 года). По итогам 2021 года ВВП Китая достиг 114,92 трлн юаней (16,52 трлн долл. США), увеличившись на 8,4 % по сравнению с предыдущим годом. По итогам 2022 года ВВП Китая вырос на 3 % в годовом исчислении и достиг 121,02 трлн юаней (17,95 трлн долл. США), что составило 18,5 % от мирового ВВП.\r\nКитай занимает первое место в мире по сельскохозяйственному производству, в первую очередь, производя кукурузу, рис, пшеницу, картофель, томаты, сорго, арахис, чай, просо, ячмень, хлопок, растительное масло и соевые бобы.";
                    break;
                case 4:
                    textBoxEconomy_BEA.Text = "Экономика Японии — одна из самых развитых экономик мира.\r\nПо размеру ВВП занимает третье место в мире после США и Китая. Отраслевая структура экономики Японии: сфера услуг – около 70%; промышленность – около 25; сельское, лесное и рыбное хозяйство – около 5%. В 1980 – 1990-е годы в ВВП Японии сократилась доля продукции сельского хозяйства, пищевой, текстильной, перерабатывающей промышленности, металлообработки и других отраслей.";
                    break;
            }
        }
    }
}
