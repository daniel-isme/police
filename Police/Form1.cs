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
        int crimes, deps, thiefs, pMen, i = 1;
        double crimeLev, corr, pE, govCareLev, pBudget, pmSal, pMoral, pWE;
        Random R = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            crimes = (int)crimesValue.Value;
            deps = (int)depsValue.Value;
            thiefs = (int)thiefsValue.Value;
            chartPolice.Series[0].Points.Clear();
            chartPolice.Series[0].Points.AddXY(0, crimes);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            crimeLev = crimes / 1000;
            govCareLev = crimeLev / 2; //- (R.NextDouble() % 0.3);
            pBudget = govCareLev * 1000000 - corr * 75000;
            if (pBudget < 0)
                pBudget = 0;
            deps = (int)(deps + (pBudget / 500000 - 1));
            if (deps < 1)
                deps = 1;
            pMen = 20 * deps;
            pmSal = (pBudget - (pBudget / 500000)) / pMen;
            if (pmSal < 0)
                pmSal = 0;
            pMoral = pmSal / 500 - crimes / 1500;
            if (pMoral <= 0)
                pMoral = 0.000001;
            if (pMoral > 1)
                pMoral = 1;
            corr = 1 / (pMoral * 10);
            if (corr < 0)
                corr = 0;
            if (corr > 1)
                corr = 1;
            pWE = pMoral - 0.05;
            if (pWE < 0)
                pWE = 0;
            pE = pWE / pMen * 100;
            if (pE < 0)
                pE = 0;
            if (pE > 1)
                pE = 1;
            crimes += (int)(thiefs + corr * 50 - pE * 2000);
            if (crimes < 0)
                crimes = 0;
            crimeLevel.Text = (crimeLev * 100).ToString() + "%";
            CorrLevel.Text = (corr * 100).ToString() + "%";
            govCareLevel.Text = (govCareLev * 100).ToString() + "%";
            pB.Text = pBudget.ToString();
            pDValue.Text = deps.ToString();
            pEValue.Text = pMen.ToString();
            moralLevel.Text = (pMoral * 100).ToString() + "%";
            pmSalary.Text = pmSal.ToString();
            chartPolice.Series[0].Points.AddXY(i, crimes);
            i++;
            thiefs = R.Next() % 50;
        }
    }
}
