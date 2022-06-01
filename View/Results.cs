using System;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1.View
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        
        private void Continue(object sender, EventArgs e)
        {
            Program.InequalityCounter++;
            if (Program.InequalityCounter>InequalitiesFactory.Inequalities.Length) Close();
            this.iterationTitle.Text = $"Iteration {Program.InequalityCounter}:";
            for (int i = 0; i < 3; i++)
            {
                this.inequalities[(Program.InequalityCounter - 1) * 3 + i].Visible = true;
            }

            this.result &= InequalitiesFactory.Inequalities[(Program.InequalityCounter - 1)].Range;
            this.resultLable.Text = this.result.IsNull?"No answer":this.result.ToString();
            if (Program.InequalityCounter == InequalitiesFactory.Inequalities.Length || result.IsNull)
            {
                Program.InequalityCounter = InequalitiesFactory.Inequalities.Length;
                this.resultTitle.Text = "Final result:";
                this.nextButton.Text = "Close";
                this.nextButton.BackColor = Style.ResetButtonColor;
                this.nextButton.ForeColor = Style.ResetButtonForeColor;
            }
            Refresh();
        }
    }
}