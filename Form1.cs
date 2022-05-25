using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Continue(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
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