﻿namespace WeightTracker
{
    partial class Form1
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
            this.currentWeightNum = new System.Windows.Forms.TextBox();
            this.currentWeightLabel = new System.Windows.Forms.Label();
            this.weightDifLabel = new System.Windows.Forms.Label();
            this.weightDifNum = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateEntered = new System.Windows.Forms.TextBox();
            this.weightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).BeginInit();
            this.SuspendLayout();
            // 
            // currentWeightNum
            // 
            this.currentWeightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeightNum.Location = new System.Drawing.Point(496, 9);
            this.currentWeightNum.Name = "currentWeightNum";
            this.currentWeightNum.Size = new System.Drawing.Size(100, 22);
            this.currentWeightNum.TabIndex = 0;
            this.currentWeightNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentWeightLabel
            // 
            this.currentWeightLabel.AutoSize = true;
            this.currentWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeightLabel.Location = new System.Drawing.Point(395, 15);
            this.currentWeightLabel.Name = "currentWeightLabel";
            this.currentWeightLabel.Size = new System.Drawing.Size(95, 16);
            this.currentWeightLabel.TabIndex = 1;
            this.currentWeightLabel.Text = "Current Weight";
            // 
            // weightDifLabel
            // 
            this.weightDifLabel.AutoSize = true;
            this.weightDifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightDifLabel.Location = new System.Drawing.Point(602, 15);
            this.weightDifLabel.Name = "weightDifLabel";
            this.weightDifLabel.Size = new System.Drawing.Size(114, 16);
            this.weightDifLabel.TabIndex = 2;
            this.weightDifLabel.Text = "Weight Difference";
            // 
            // weightDifNum
            // 
            this.weightDifNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightDifNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightDifNum.Location = new System.Drawing.Point(722, 9);
            this.weightDifNum.Name = "weightDifNum";
            this.weightDifNum.Size = new System.Drawing.Size(100, 22);
            this.weightDifNum.TabIndex = 4;
            this.weightDifNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(188, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(95, 16);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date Weighed";
            // 
            // dateEntered
            // 
            this.dateEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEntered.Location = new System.Drawing.Point(289, 9);
            this.dateEntered.Name = "dateEntered";
            this.dateEntered.Size = new System.Drawing.Size(100, 22);
            this.dateEntered.TabIndex = 5;
            this.dateEntered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weightChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weightChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weightChart.Legends.Add(legend1);
            this.weightChart.Location = new System.Drawing.Point(12, 90);
            this.weightChart.Name = "weightChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.weightChart.Series.Add(series1);
            this.weightChart.Size = new System.Drawing.Size(806, 342);
            this.weightChart.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(93, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 470);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.weightChart);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateEntered);
            this.Controls.Add(this.weightDifNum);
            this.Controls.Add(this.weightDifLabel);
            this.Controls.Add(this.currentWeightLabel);
            this.Controls.Add(this.currentWeightNum);
            this.Name = "Form1";
            this.Text = "Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentWeightNum;
        private System.Windows.Forms.Label currentWeightLabel;
        private System.Windows.Forms.Label weightDifLabel;
        private System.Windows.Forms.Label weightDifNum;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateEntered;
        private System.Windows.Forms.DataVisualization.Charting.Chart weightChart;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
