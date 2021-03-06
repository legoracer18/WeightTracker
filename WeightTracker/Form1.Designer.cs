﻿namespace WeightTracker
{
    partial class weightTrackerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weightTrackerWindow));
            this.currentWeightNum = new System.Windows.Forms.TextBox();
            this.currentWeightLabel = new System.Windows.Forms.Label();
            this.weightDifNum = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateEntered = new System.Windows.Forms.TextBox();
            this.weightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.weightDifPer = new System.Windows.Forms.Label();
            this.lostGained = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pleaseWaitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).BeginInit();
            this.SuspendLayout();
            // 
            // currentWeightNum
            // 
            this.currentWeightNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentWeightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeightNum.Location = new System.Drawing.Point(497, 37);
            this.currentWeightNum.Name = "currentWeightNum";
            this.currentWeightNum.Size = new System.Drawing.Size(100, 22);
            this.currentWeightNum.TabIndex = 3;
            this.currentWeightNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentWeightLabel
            // 
            this.currentWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentWeightLabel.AutoSize = true;
            this.currentWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeightLabel.Location = new System.Drawing.Point(396, 43);
            this.currentWeightLabel.Name = "currentWeightLabel";
            this.currentWeightLabel.Size = new System.Drawing.Size(95, 16);
            this.currentWeightLabel.TabIndex = 2;
            this.currentWeightLabel.Text = "Current Weight";
            // 
            // weightDifNum
            // 
            this.weightDifNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weightDifNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightDifNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightDifNum.Location = new System.Drawing.Point(616, 37);
            this.weightDifNum.Name = "weightDifNum";
            this.weightDifNum.Size = new System.Drawing.Size(100, 22);
            this.weightDifNum.TabIndex = 5;
            this.weightDifNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(189, 43);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(95, 16);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date Weighed";
            // 
            // dateEntered
            // 
            this.dateEntered.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEntered.Location = new System.Drawing.Point(290, 37);
            this.dateEntered.Name = "dateEntered";
            this.dateEntered.Size = new System.Drawing.Size(100, 22);
            this.dateEntered.TabIndex = 1;
            this.dateEntered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weightChart
            // 
            this.weightChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.weightChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weightChart.Legends.Add(legend1);
            this.weightChart.Location = new System.Drawing.Point(12, 65);
            this.weightChart.Name = "weightChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.weightChart.Series.Add(series1);
            this.weightChart.Size = new System.Drawing.Size(810, 364);
            this.weightChart.TabIndex = 8;
            this.weightChart.Text = "Please Load or Save a file to see the graph.";
            this.weightChart.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(93, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 6;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // weightDifPer
            // 
            this.weightDifPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weightDifPer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightDifPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightDifPer.Location = new System.Drawing.Point(722, 37);
            this.weightDifPer.Name = "weightDifPer";
            this.weightDifPer.Size = new System.Drawing.Size(100, 22);
            this.weightDifPer.TabIndex = 10;
            this.weightDifPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lostGained
            // 
            this.lostGained.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lostGained.AutoSize = true;
            this.lostGained.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostGained.Location = new System.Drawing.Point(662, 15);
            this.lostGained.Name = "lostGained";
            this.lostGained.Size = new System.Drawing.Size(144, 16);
            this.lostGained.TabIndex = 11;
            this.lostGained.Text = "Load file to see results.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter in new entry.";
            // 
            // pleaseWaitLabel
            // 
            this.pleaseWaitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pleaseWaitLabel.AutoSize = true;
            this.pleaseWaitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseWaitLabel.Location = new System.Drawing.Point(73, 202);
            this.pleaseWaitLabel.Name = "pleaseWaitLabel";
            this.pleaseWaitLabel.Size = new System.Drawing.Size(691, 31);
            this.pleaseWaitLabel.TabIndex = 13;
            this.pleaseWaitLabel.Text = "Please Open a file or Save a new entry to see the graph.";
            // 
            // weightTrackerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.pleaseWaitLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lostGained);
            this.Controls.Add(this.weightDifPer);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.weightChart);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateEntered);
            this.Controls.Add(this.weightDifNum);
            this.Controls.Add(this.currentWeightLabel);
            this.Controls.Add(this.currentWeightNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 480);
            this.Name = "weightTrackerWindow";
            this.Text = "Weight Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentWeightNum;
        private System.Windows.Forms.Label currentWeightLabel;
        private System.Windows.Forms.Label weightDifNum;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateEntered;
        private System.Windows.Forms.DataVisualization.Charting.Chart weightChart;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label weightDifPer;
        private System.Windows.Forms.Label lostGained;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pleaseWaitLabel;
    }
}

