// Program Name:    StatisticsCalculator
//
//                  This application will allow the demonstration of ability to
//                  • use arrays to manipulate a large quantity of data
//                  • perform file operations to read data into the application, and write the data back out to a file.
//                  
//
using System;
using System.IO; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsCalculator
{
    public partial class statisticsCalculatorMainForm : Form
    {
        private StreamReader inputFile; 
        private StreamWriter outputFile; // To get the output of the file

        private List<int> data = new List<int>(); // To create the list

        public statisticsCalculatorMainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //To exit the application
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            // To open the file
            OpenFileDialog getFilePathDialog = new OpenFileDialog();

            if (getFilePathDialog.ShowDialog() == DialogResult.OK)
            {

                var rawData = File.ReadAllLines(getFilePathDialog.FileName).ToList();
                var dataRowsCount = int.Parse(rawData.First()); // rows count from first line
                var characterError = false;
                try
                {
                    var num = 0;
                    foreach (var item in rawData)
                    {
                        num = Convert.ToInt32(item);
                    }
                }
                catch (Exception ex)
                {
                    characterError = true;
                }

                
                if (characterError) // The message error have a letter
                {
                    MessageBox.Show("A data has non‐numeric characters (i.e.letter)");
                    return;
                }

                data = rawData.Skip(1).Select(d => Convert.ToInt32(d)).ToList();

                if (data.Where(d => d < 0).Count() > 0) // The message error have a negative number
                {
                    MessageBox.Show("A data has a negative number");
                    return;
                }

                if (data.Count() >= 100) //The message error have data more than 99
                {
                    MessageBox.Show("A data has a value greater than 99");
                    return;
                }

                if (data.Count() < dataRowsCount) // The message error not enough data 
                {
                    MessageBox.Show($"The first line of the file declares that there should be {dataRowsCount} data samples present, however there are only {data.Count()}.This will cause a premature End of File");
                    return;
                }

                dataSetTextBox.Text = File.ReadAllText(getFilePathDialog.FileName); //read the file and write the information in the textbox
            }
        }

        private void calculateStatisticsButton_Click(object sender, EventArgs e)
        {
            double maxValue = double.MaxValue;  //the declation of maximum value
            double minValue = double.MinValue;  //the declation of minimum value
            double rangeValue;                  //the declation of range value
            double meanValue;                   //the declation of mean value
            double medianValue;                 //the declation of median value

            maxValue = data.Max();
            minValue = data.Min();

            // Get Range value
            rangeValue = maxValue - minValue;
            // Get Mean value
            meanValue = data.Average();
            // Get Median value
            var orderedData = data.OrderBy(d => d);
            var mid = orderedData.Count() / 2;
            if (orderedData.Count() % 2 == 0) // even count
            {
                medianValue = (orderedData.ElementAt(mid - 1) + orderedData.ElementAt(mid)) / 2;
            }
            else
            {
                medianValue = orderedData.ElementAt(mid);
            }
            
            minimumValueTextBox.Text = $"{minValue}";   // Prints the maximum value
            maximumValueTextBox.Text = $"{maxValue}";   // Prints the minimum value
            rangeTextBox.Text = $"{rangeValue}";        // Prints the range value
            meanTextBox.Text = $"{meanValue}";          // Prints the mean value
            medianTextBox.Text = $"{medianValue}";      // Prints the median value

            // to get histogram value
            var values1 = 0;
            var values2 = 0;
            var values3 = 0;
            var values4 = 0;
            var values5 = 0;
            var values6 = 0;
            var values7 = 0;
            var values8 = 0;
            var values9 = 0;
            var values10 = 0;
            values1 = data.Where(d => d > 0 && d < 10).Count();
            values2 = data.Where(d => d > 10 && d < 20).Count();
            values3 = data.Where(d => d > 20 && d < 30).Count();
            values4 = data.Where(d => d > 30 && d < 40).Count();
            values5 = data.Where(d => d > 40 && d < 50).Count();
            values6 = data.Where(d => d > 50 && d < 60).Count();
            values7 = data.Where(d => d > 60 && d < 70).Count();
            values8 = data.Where(d => d > 70 && d < 80).Count();
            values9 = data.Where(d => d > 80 && d < 90).Count();
            values10 = data.Where(d => d > 90 && d < 100).Count();

            // to print the histogram
            histogramTextBox.Clear();
            histogramTextBox.Text += $"(0 to 10) ({values1}) {GetStars(values1)}" + Environment.NewLine;
            histogramTextBox.Text += $"(10 to 20) ({values2}) {GetStars(values2)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values3}) {GetStars(values3)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values4}) {GetStars(values4)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values5}) {GetStars(values5)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values6}) {GetStars(values6)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values7}) {GetStars(values7)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values8}) {GetStars(values8)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values9}) {GetStars(values9)}" + Environment.NewLine;
            histogramTextBox.Text += $"(0 to 10) ({values10}) {GetStars(values10)}";

        }

        private string GetStars(int count) //to get the stars for the histogram
        {
            var stars = "";
            for (int i = 0; i < count; i++)
            {
                stars += "*";
            }
            return stars;
        }

        private void dataSetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            //To save the data 
            SaveFileDialog saveFile = new SaveFileDialog();

            DialogResult result = saveFile.ShowDialog();

            /*if (result != DialogResult.OK)
            {
                filePathTextBox.Text = "User Canceled";
                return;
            }
            try
            {
                outputFile = new StreamWriter(saveFile.FileName);
            }
            catch
            {
                MessageBox.Show("File was not created");
            }*/

            outputFile.WriteLine(dataSetTextBox.Text); //To write the data to the new file
        }
    }
}
