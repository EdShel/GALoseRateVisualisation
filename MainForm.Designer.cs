namespace GALoseRateVisualtisation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.variantBox = new System.Windows.Forms.NumericUpDown();
            this.variantLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantBox)).BeginInit();
            this.SuspendLayout();
            // 
            // plot
            // 
            this.plot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.plot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plot.Legends.Add(legend1);
            this.plot.Location = new System.Drawing.Point(2, 81);
            this.plot.Name = "plot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Lose Rate";
            this.plot.Series.Add(series1);
            this.plot.Size = new System.Drawing.Size(786, 357);
            this.plot.TabIndex = 0;
            // 
            // variantBox
            // 
            this.variantBox.Location = new System.Drawing.Point(48, 36);
            this.variantBox.Name = "variantBox";
            this.variantBox.Size = new System.Drawing.Size(120, 20);
            this.variantBox.TabIndex = 1;
            this.variantBox.ValueChanged += new System.EventHandler(this.OnVariantInput);
            // 
            // variantLabel
            // 
            this.variantLabel.AutoSize = true;
            this.variantLabel.Location = new System.Drawing.Point(48, 13);
            this.variantLabel.Name = "variantLabel";
            this.variantLabel.Size = new System.Drawing.Size(45, 13);
            this.variantLabel.TabIndex = 2;
            this.variantLabel.Text = "Варіант";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.variantLabel);
            this.Controls.Add(this.variantBox);
            this.Controls.Add(this.plot);
            this.Name = "MainForm";
            this.Text = "ВІА ПЗ2 Візуалізація";
            ((System.ComponentModel.ISupportInitialize)(this.plot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart plot;
        private System.Windows.Forms.NumericUpDown variantBox;
        private System.Windows.Forms.Label variantLabel;
    }
}

