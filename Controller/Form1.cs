using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Continue(object sender, EventArgs e)
        {
            List<int> incorrectFields = new List<int>();
            for (int i = 0; i < textFields.Length; i++)
            {
                if (!InputValidator.ValidateInput(textFields[i].Text))
                {
                    incorrectFields.Add(i + 1);
                }
                else
                {
                    InequalitiesFactory.Sources[i] = InputValidator.ReformatInput(textFields[i].Text);
                }
            }

            if (incorrectFields.Count > 0)
            {
                string errorMessage = "Incorrect input in field" + (incorrectFields.Count > 1 ? "s" : "") +
                                      $" {incorrectFields[0]}";
                for (int i = 1; i < incorrectFields.Count - 1; i++)
                {
                    errorMessage += $", {incorrectFields[i]}";
                }

                if (incorrectFields.Count > 1) errorMessage += $" and {incorrectFields[^1]}";
                MessageBox.Show(errorMessage);
            }
            else
            {
                Program.Form1Closed = false;
                Close();
            }
        }

        private void ResetFields(object sender, EventArgs e)
        {
            foreach (var field in textFields)
            {
                field.Text = "";
            }
        }
    }
}