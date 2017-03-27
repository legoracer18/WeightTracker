using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WeightTracker
{
    public partial class weightTrackerWindow : Form
    {
        public List<Weights> chartList = new List<Weights>();
        public List<Weights> sortedList = new List<Weights>();

        public weightTrackerWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Weight Tracker File (*.wt)|*.wt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fileOut = new StreamWriter(saveFileDialog.FileName);
                
                string outputString = "";
                if (currentWeightNum.Text != "" && dateEntered.Text != "")
                {
                    try
                    {
                        // Add new fields to sorted list
                        sortedList.Add(new Weights() { WeightNum = Convert.ToDouble(currentWeightNum.Text), Date = Convert.ToDateTime(dateEntered.Text) });
                        // re-sort the list by the date
                        sortedList = sortedList.OrderBy(x => x.Date).ToList();
                        chartList = sortedList.OrderBy(x => x.Date).ToList();

                        foreach (var el in sortedList)
                            outputString = outputString + el.WeightNum.ToString() + "," + el.Date.ToString("d") + "\n";
                        fileOut.Write(outputString);
                        fileOut.Dispose();
                        displayDifference();
                        loadChart();
                    }
                    catch
                    {
                        fileOut.Dispose();
                        MessageBox.Show("Most likely the date was wrong, please double check the entries.", "Save Failed");
                    }
                    
                }
                else
                {
                    fileOut.Dispose();
                    MessageBox.Show("Missing either the date or weight.", "Save Failed");
                }
                    
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Weight Tracker File (*.wt)|*.wt";
            saveFileDialog.RestoreDirectory = true;
            bool readSuccess = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openFileDialog.FileName);
                string line = "";
                sortedList.Clear();

                // Read in each line
                while (line != null)
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        // Split each line up on the ','. Expected from the file is "weightNumber,date".
                        string[] subStrings = line.Split(',');
                        // Add each string to the Weights class for the variable it corresponds to, in the List.
                        sortedList.Add(new Weights() { WeightNum = Convert.ToDouble(subStrings[0]), Date = Convert.ToDateTime(subStrings[1]) });
                    }
                    // Sort the list by the date
                    sortedList = sortedList.OrderBy(x => x.Date).ToList();
                    chartList = sortedList.OrderBy(x => x.Date).ToList();

                }
                // Clean up
                file.Dispose();
                readSuccess = true;
            }

            if (readSuccess)
            {
                displayDifference();
                loadChart();
            }
        }

        private void loadChart()
        {
            int max = 100;
            int min = 300;

            weightChart.Series["Weight"].Points.Clear();
            foreach (var el in chartList)
            {
                this.weightChart.Series["Weight"].Points.AddXY(el.Date.ToShortDateString(), el.WeightNum.ToString());
                if (min + 10 > el.WeightNum)
                    min = Convert.ToInt16(el.WeightNum) - 10;
                if (max - 10 < el.WeightNum)
                    max = Convert.ToInt16(el.WeightNum) + 10;
                
            }
            this.weightChart.ChartAreas[0].AxisY.Minimum = min;
            this.weightChart.ChartAreas[0].AxisY.Maximum = max;
            this.weightChart.Visible = true;
            this.pleaseWaitLabel.Visible = false;
            chartList.Clear();
        }

        private void displayDifference()
        {
            if (sortedList.Count != 0)
            {
                double startWeight = sortedList[0].WeightNum;
                int listCount = sortedList.Count - 1;
                double lastWeight = sortedList[listCount].WeightNum;
                string differencePercent = "";
                string differencePounds = "";
                double differenceNum = lastWeight - startWeight;
                differenceNum = Math.Truncate(100 * differenceNum) / 100;
                double differencePer = (differenceNum / startWeight) * 100;
                differencePer = Math.Truncate(100 * differencePer) / 100;

                if (differenceNum < 0)
                {
                    differenceNum = differenceNum * -1;
                    differencePer = differencePer * -1;
                    lostGained.Text = "You have lost:";
                    differencePercent =  Convert.ToString(differencePer) + "%";
                    weightDifPer.Text = differencePercent;
                    differencePounds = Convert.ToString(differenceNum) + " lbs";
                    weightDifNum.Text = differencePounds;
                }
                else
                {
                    lostGained.Text = "You have gained:";
                    differencePercent = Convert.ToString(differencePer) + "%";
                    weightDifPer.Text = differencePercent;
                    differencePounds = Convert.ToString(differenceNum) + " lbs";
                    weightDifNum.Text = differencePounds;
                }
            }
            else
            {
                MessageBox.Show("There may be something wrong with the file you are trying to open.\nPlease check the file and try again.", "Load Failed");
            }
            
        }
    }
}
