using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();    
        }
        Random rnd = new Random();
        double NI = 3000; //число из вне(изменяющееся со временем) ) -- Преступники
        double CR = 6230; //Преступления
        double CRL = 2;// Уровень преступности
        double CRLGOVCARE = 0.5;//Обеспокоенноть государства
        double PB = 300000;//Бюджет полиции
        double SALARY = 60000;//ЗП
        double MORAL = 0.68;//Мораль
        double CORR = 0.32;//Коррупция
        int PDS = 2;//Количество отделений(целое число)
        double PMEN = 200;//Штат
        double PE = 3;//Эффективность полиции
        double PWE = 0.6;//Качество работы
        double R = 0.3;//число от 0 до 0.30

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CR = CR + (NI * 2 + CORR * 1000 - PE * 100);
            if (CR / 10000 <= 1 / 3)
                CRL = 1;//1 - низкий
            else if (CR / 10000 > 1 / 3 && CR / 10000 <= 2 / 3)
                CRL = 2;//2 - средний
            else if (CR / 10000 > 2 / 3)
                CRL = 3;//3 - высокий --Уровень преступности
            R = (rnd.Next(0, 30)/100);
            if (CRL / 3 - R > 0)
                CRLGOVCARE = CRL / 3 - R;
            else
                CRLGOVCARE = CRL / 3;
            PB = CRLGOVCARE * 100000000 - CORR * 750000;

            if (PB / (SALARY * (PDS + 1) * 100) < 2 / 3)
                PDS++;
            else if (((PB * 3) / (2 * SALARY * 100)) >= PDS)
                PDS = (int)((PB * 3) / (2 * SALARY * 100));
            PMEN = 100 * PDS;

            if (SALARY <= ((PB * 3) / (2 * PDS * 100)))
                SALARY = (int)((PB * 3) / (2 * PDS * 100));
            if (SALARY / 50000 - CR / 10000 > 1)
                MORAL = 1;
            else if (SALARY / 50000 - CR / 10000 < 0)
                MORAL = 0.01;
            else
                MORAL = SALARY / 50000 - CR / 10000;
            CORR = 1 - MORAL;
            PWE = MORAL - 0.05;
            PE = PWE  / PMEN  ;/////////

            NItext.Text = NI.ToString();
            CRtext.Text = CR.ToString();
            CRLtext.Text = CRL.ToString();
            CRLGOVCAREtext.Text = CRLGOVCARE.ToString();
            PBtext.Text = PB.ToString();
            SALARYtext.Text = ((int)SALARY).ToString();
            MORALtext.Text = MORAL.ToString();
            CORRtext.Text = CORR.ToString();
            PDStext.Text = ((int)PDS).ToString();
            PMENtext.Text = PMEN.ToString();
            PEtext.Text = PE.ToString();
            PWEtext.Text = PWE.ToString();
        }
    }
}
