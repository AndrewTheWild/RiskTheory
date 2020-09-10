using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Calculate probability of rain
        private void trackBarMain_Scroll(object sender, EventArgs e)
        {
            var val = trackBarMain.Value;
            double tick=val*0.01;
            tb_ProbabilityRain.Text = tick.ToString();
        }
        //Calculate untility
        private void Calculate()
        {
            //Probability
            var probabilityRain = double.Parse(tb_ProbabilityRain.Text);
            var probabilitySun = 1-probabilityRain;
           #region  Rating 
            //Rain
            var ratingRain1 = decimal.ToDouble(numUpDown_UtilityRain1.Value);
            var ratingRain2 = decimal.ToDouble(numUpDown_UtilityRain2.Value);
            //Sun
            var ratingSun1 = decimal.ToDouble(numUpDown_UtilitySun1.Value);
            var ratingSun2 = decimal.ToDouble(numUpDown_UtilitySun2.Value);
            #endregion
            //Untility
            var untilityForest = (probabilitySun * ratingSun1) + (probabilityRain * ratingRain1);
            var untilityHome = (probabilitySun * ratingSun2) + (probabilityRain * ratingRain2);
            //Decide
            lbl_HomeRes.Text = untilityHome.ToString();
            lbl_ForestRes.Text = untilityForest.ToString();
            if (untilityForest > untilityHome) lbl_Decide.Text = "Йти чілити в ліс)))";
            else if(untilityForest < untilityHome) lbl_Decide.Text = "Сидіти вдома,дивитися серіали(";
                    else lbl_Decide.Text = "На твій розсуд ,вдача любить сміливих";
        }
        //Event change value
        private void ValueChange(object sender, EventArgs e) => Calculate();
    }
}
