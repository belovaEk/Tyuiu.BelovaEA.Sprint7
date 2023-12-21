﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    public partial class FormPolitics_BEA : Form
    {
        public FormPolitics_BEA()
        {
            InitializeComponent();
        }

        private void comboBoxChoosingCountry_BEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChoosingCountry_BEA.SelectedIndex)
            {
                case 0:
                    pictureBoxPresident_BEA.Image = Properties.Resources.president_Russia;
                    labelNamePresident_BEA.Text = null;
                    labelNamePresident_BEA.Text += "Владимир Владимирович Путин";
                    textBoxPolitical_BEA.Text = "В соответствии с Конституцией «РОССИЙСКАЯ ФЕДЕРАЦИЯ - РОССИЯ - это демократическое федеративное правовое государство с республиканской формой правления». Носителем суверенитета и единственным источником власти в Российской Федерации является ее многонациональный народ. Народ реализует свою власть непосредственно, а также посредством органов государственной власти и органов местного самоуправления. Сегодняшняя Россия -это республика.Президент, который является главой государства, обладает широкими полномочиями. Он определяет, в соответствии с Конституцией и федеральными законами, основные направления внутренней и внешней политики страны.";
                    break;

                case 1:
                    pictureBoxPresident_BEA.Image = Properties.Resources.president_USA;
                    labelNamePresident_BEA.Text = null;
                    labelNamePresident_BEA.Text = "Джо Байден";
                    textBoxPolitical_BEA.Text = "Соединённые Штаты Америки — федеративная президентская республика, состоящая из 50 штатов и федерального округа Колумбия. По форме правления США - президентская республика. Федеральная конституция устанавливает принцип \"разделения властей\" - законодательная власть принадлежит Конгрессу, исполнительная - Президенту, судебная Верховному и другим судам. Каждый штат имеет свою конституцию, свои законодательные органы двухпалатные (в штате Небраска - однопалатную) легислатуры, свою исполнительную власть, во главе которой стоит избираемый населением губернатор, наконец, свою судебную систему.";
                    break;

                case 2:
                    pictureBoxPresident_BEA.Image = Properties.Resources.president_France;
                    labelNamePresident_BEA.Text = null;
                    labelNamePresident_BEA.Text = "Эмманюэль Макрон";
                    textBoxPolitical_BEA.Text = "Политическую структуру Франции составляют президент республики, являющийся главой государства, премьер-министр Франции, правительство, главой которого является Премьер-министр, парламент, состоящий из двух палат: Национального собрания и Сената, а также Конституционный совет. На местном уровне власть представлена руководством департаментов, регионов, коммун. Соотношение полномочий президента республики и премьер-министра зависит от расстановки сил в парламенте, точнее — в Национальном собрании. В одном случае в Национальном собрании есть президентское большинство (то есть большинство у партии президента), в другом случае в Национальном собрании большинство составляет оппозиционная партия. Поэтому форму правления во Франции называют президентско-парламентской республикой.";
                    break;

                case 3:
                    pictureBoxPresident_BEA.Image = Properties.Resources.president_China;
                    labelNamePresident_BEA.Text = null;
                    labelNamePresident_BEA.Text = "Си Цзиньпин";
                    textBoxPolitical_BEA.Text = "Государственный строй Китайской Народной Республики основан на конституции КНР, согласно которой «Китайская Народная Республика есть социалистическое государство демократической диктатуры народа, руководимое рабочим классом (через Коммунистическую партию Китая) и основанное на союзе рабочих и крестьян. Согласно этим конституционным положениям, в стране установлен социалистический строй, вся власть принадлежит народу, народ осуществляет государственную власть через Всекитайское собрание народных представителей и местные собрания народных представителей различных ступеней.";
                    break;

                case 4:
                    pictureBoxPresident_BEA.Image = Properties.Resources.president_Japan;
                    labelNamePresident_BEA.Text = null;
                    labelNamePresident_BEA.Text = "Нарухито";
                    textBoxPolitical_BEA.Text = "Япония — унитарное демократическое национальное государство, парламентская конституционная монархия. Основной закон — Конституция 1947 года, которая предусматривает верховенство права, коллегиальность управления, незыблемость и неприкосновенность прав человека, соблюдение принципов пацифизма. Носителем государственного суверенитета является японский народ. Власть делится на три ветви — законодательную , исполнительную и судебную. Первая представлена двухпалатным парламентом, вторая — Кабинетом министров и органами исполнительной власти на местах, третья — Верховным и региональными судами. Муниципалитеты разных уровней имеют широкие права самоуправления. Высшим органом власти является Парламент. Формальный глава государства — Император Японии: фактический — премьер-министр, руководитель Кабинета министров. Вопреки демократическим декларациям, ярчайшей чертой политической системы является клановость, уходящая своими корнями в феодальное прошлое Японии.";
                    break;

            }
        }

      
    }
}
