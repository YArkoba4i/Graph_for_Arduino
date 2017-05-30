namespace Graph_for_Arduino
{
    partial class FormBarometr
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraphTH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnConfigureUART = new System.Windows.Forms.Button();
            this.btnReadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraphTH)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphTH
            // 
            chartArea1.Name = "ChartArea1";
            this.GraphTH.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraphTH.Legends.Add(legend1);
            this.GraphTH.Location = new System.Drawing.Point(140, 12);
            this.GraphTH.Name = "GraphTH";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            this.GraphTH.Series.Add(series1);
            this.GraphTH.Series.Add(series2);
            this.GraphTH.Size = new System.Drawing.Size(708, 461);
            this.GraphTH.TabIndex = 0;
            this.GraphTH.Text = "chart1";
            // 
            // btnConfigureUART
            // 
            this.btnConfigureUART.Location = new System.Drawing.Point(13, 13);
            this.btnConfigureUART.Name = "btnConfigureUART";
            this.btnConfigureUART.Size = new System.Drawing.Size(75, 23);
            this.btnConfigureUART.TabIndex = 1;
            this.btnConfigureUART.Text = "Connect";
            this.btnConfigureUART.UseVisualStyleBackColor = true;
            this.btnConfigureUART.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(13, 43);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(75, 23);
            this.btnReadData.TabIndex = 2;
            this.btnReadData.Text = "Read data";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBarometr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 485);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.btnConfigureUART);
            this.Controls.Add(this.GraphTH);
            this.Name = "FormBarometr";
            this.Text = "Barometr";
            ((System.ComponentModel.ISupportInitialize)(this.GraphTH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphTH;
        private System.Windows.Forms.Button btnConfigureUART;
        private System.Windows.Forms.Button btnReadData;
    }
}

