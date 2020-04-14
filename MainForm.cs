using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GALoseRateVisualtisation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnVariantInput(object sender, EventArgs e)
        {
            NumericUpDown input = sender as NumericUpDown;
            var points = plot.Series["Lose Rate"]?.Points;

            if (input != null && points != null)
            {
                int variant = (int)input.Value;

                points.Clear();

                foreach(var stage in DataGenerator.GetStagesInfo(variant))
                {
                    double loseRate = 1d - (double)(stage.Won + stage.AlmostWon) / stage.Started;
                    points.AddXY(stage.StageIndex, loseRate);
                }
            }
        }
    }
}
