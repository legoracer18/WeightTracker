using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Xml File (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Weights currentWeight = new Weights();
                currentWeight.Date = dateEntered.Text.ToString();
                currentWeight.WeightNum = currentWeightNum.Text.ToString();
                XmlSave.SaveData(currentWeight, saveFileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Xml File (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                MessageBox.Show(filename);
            }
            

        }
    }

    
}
