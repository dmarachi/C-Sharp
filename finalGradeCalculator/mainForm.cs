// Program Name:    finalGradeCalculator
//
// Author:          Dima Marachi
//
// Date:            22-March-2019
//
// Description:     Assignment #2 ‐ A Course Final Grade Calculator Using a GUI ‐ for ICT 710 023 Computer Programming Level I
//
//                  The application will allow the entry of an arbitrary number of quiz marks, a single midterm mark and the
//                  final examination mark.Once these have been entered, a calculate button would be pressed produce the
//                  final grade, which will be displayed in the window along with the corresponding letter grade.
//                  
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalGradeCalculator
{
    public partial class mainForm : Form
    {
        private double maxValue = double.MaxValue;
        private double minValue = double.MinValue;

        public mainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the Application
        }

        private void calculateGradeButton_Click(object sender, EventArgs e)
        {
            double sum = 0; // the sum of quizzes from listbox
            double average = 0;
            int i = 0;
            double midtermMark; // the midterm marked
            double finalExamMark; // the final exam mark
            double percentage; // the percentage calculated from quizzes, midterm and final exam
            double quizzesPercentage; // the quizzes percentage calculated
            double midtermMarkPercentage; // the midterm percentage calculated
            double finalExamMarkPercentage; // the final exam percentage calculated

            midtermMark = double.Parse(midtermMarkTextbox.Text);
            finalExamMark = double.Parse(finalExamMarkTextbox.Text);

            //Calculates the quizzes from the listbox
            /**/

            
            if (dropHighestAndLowestQuizzesCheckbox.Checked)//(Dropping the quizzes)
            {
                for (i = 0; i < quizzesGotListbox.Items.Count; i++)
                {
                    sum = sum + Convert.ToDouble(quizzesGotListbox.Items[i].ToString());
                }

                sum = sum - maxValue - minValue;
                average = sum / (Convert.ToDouble(quizzesGotListbox.Items[i].ToString()) - 2);
            }
            else
            {
                average = sum / Convert.ToDouble(quizzesGotListbox.Items[i].ToString());
            }

            sum = sum / quizzesGotListbox.Items.Count; //getting the avarage of the quiz marks from the list box
           // calculatedquizmarksTextbox.Text = sum.ToString(); // Prints the calculated value in the textbox
            calculatedquizmarksTextbox.Text = average.ToString(); // Prints the calculated value in the textbox

            quizzesPercentage = (sum / 100) * 20;  //Calculates the percentage of all quizzes marks entered
            midtermMarkPercentage = (midtermMark / 100) * 30; //Calculates the percentage of midterm mark
            finalExamMarkPercentage = (finalExamMark / 100) * 50; //Calculates the percentage of final exam mark
            percentage = quizzesPercentage + midtermMarkPercentage + finalExamMarkPercentage;  // Calculates the percentage of the quizzes, midterm and final exam

            // Prints calculated percentage in number
            calculatedMarkInNumberTextbox.Text = percentage.ToString();

            // Prints calculated percentage in Letter
            if (percentage >= 95 && percentage <= 100)
            {
                calculatedMarkInLetterTextbox.Text = "A+";
            }
            else if (percentage >= 90 && percentage <= 94)
            {
                calculatedMarkInLetterTextbox.Text = "A";
            }
            else if (percentage >= 85 && percentage <= 89)
            {
                calculatedMarkInLetterTextbox.Text = "A-";
            }
            else if (percentage >= 80 && percentage <= 84)
            {
                calculatedMarkInLetterTextbox.Text = "B+";
            }
            else if (percentage >= 75 && percentage <= 79)
            {
                calculatedMarkInLetterTextbox.Text = "B";
            }
            else if (percentage >= 70 && percentage <= 74)
            {
                calculatedMarkInLetterTextbox.Text = "B-";
            }
            else if (percentage >= 67 && percentage <= 69)
            {
                calculatedMarkInLetterTextbox.Text = "C+";
            }
            else if (percentage >= 64 && percentage <= 66)
            {
                calculatedMarkInLetterTextbox.Text = "C";
            }
            else if (percentage >= 60 && percentage <= 63)
            {
                calculatedMarkInLetterTextbox.Text = "C-";
            }
            else if (percentage >= 55 && percentage <= 59)
            {
                calculatedMarkInLetterTextbox.Text = "D+";
            }
            else if (percentage >= 50 && percentage <= 54)
            {
                calculatedMarkInLetterTextbox.Text = "D";
            }
            else if (percentage >= 0 && percentage <= 49)
            {
                calculatedMarkInLetterTextbox.Text = "F";
            }
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            //Add the quiz marks enterd to the listbox and if nothing entered show the error message
            if (this.quizMarkTextbox.Text != "")
            {
                quizzesGotListbox.Items.Add(this.quizMarkTextbox.Text);
                this.quizMarkTextbox.Focus(); //get the focus 
                this.quizMarkTextbox.Clear(); //Clear quizMarkTextbox from the number entered
            }
            else
            {
                MessageBox.Show("Please enter quize mark.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.quizMarkTextbox.Focus();
            }
        }

        private void resetAllMarksButton_Click(object sender, EventArgs e)
        {
            //To clear all the data in textboxes
            foreach (var mark in this.Controls)
            {
                // Check the items in the textboxs and clear them
                if (mark.GetType().Equals(typeof(TextBox)))
                {
                    TextBox textbox1 = mark as TextBox;
                    textbox1.Text = string.Empty;
                }
            }

            // Remove quiz marks from listbox when selected
            quizzesGotListbox.Items.Clear();
        }

        private void resetQuizMarksButton_Click(object sender, EventArgs e)
        {
            quizzesGotListbox.Items.Clear(); //To clear all the data in listbox
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Show this error message when button clicked and no mark was selected
            if (this.quizzesGotListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Must select a quiz mark before clicking the Remove Button!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Remove quiz marks from listbox when selected
            if (this.quizzesGotListbox.SelectedIndex >= -1)
            {
                this.quizzesGotListbox.Items.RemoveAt(this.quizzesGotListbox.SelectedIndex);
            }
        }

        private void quizMarkTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // To not Allow any string charaters in the Quiz Mark Textbox
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void midtermMarkTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // To not Allow any string charaters in the Midterm Mark Textbox
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void finalExamMarkTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // To not Allow any string charaters in the Final Exam Mark Textbox
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void dropHighestAndLowestQuizzesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in quizzesGotListbox.Items)
            {
                double value = double.Parse(item.ToString());

                if (value > maxValue) //Find the maximum value
                {
                    maxValue = value;
                            }
                if (value < minValue) //Find the minimum value
                {
                    minValue = value;
             ;
                }
            }

            // Let's push UI out of the loop (we want min and to be printed once)
            lblMaxResult.Text = $"{maxValue}";
            lblMinResult.Text = $"{minValue}";


        }

        private void calculatedMarkInNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}