using System.ComponentModel;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1.View
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.iterationTitle = new System.Windows.Forms.Label();
            this.inequalities = new Label[InequalitiesFactory.Inequalities.Length * 3];
            this.resultTitle = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.result = new Range(null, null);
            this.SuspendLayout();
            // 
            // IterationTitle
            // 
            this.iterationTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.iterationTitle.Location = new System.Drawing.Point(162, 50);
            this.iterationTitle.Name = "iterationTitle";
            this.iterationTitle.Size = new System.Drawing.Size(277, 20);
            this.iterationTitle.TabIndex = 0;
            this.iterationTitle.Text = InequalitiesFactory.Inequalities.Length>0?"Iteration 0:":"Final result:";
            this.iterationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Inequalities
            //
            for (int i = 0; i < InequalitiesFactory.Inequalities.Length; i++)
            {
                inequalities[i*3] = new System.Windows.Forms.Label();
                inequalities[i*3].Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                inequalities[i*3].Location = new System.Drawing.Point(50, 125+30*i);
                inequalities[i*3].Name = $"ineq{i+1}";
                inequalities[i*3].Size = new System.Drawing.Size(320, 20);
                inequalities[i*3].TabIndex = i*3+1;
                inequalities[i*3].Text = InequalitiesFactory.Inequalities[i].ToString();
                inequalities[i*3].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                inequalities[i * 3].Visible = false;
                this.Controls.Add(inequalities[i*3]);
                
                inequalities[i*3+1] = new System.Windows.Forms.Label();
                inequalities[i*3+1].Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                inequalities[i*3+1].Location = new System.Drawing.Point(380, 125+30*i);
                inequalities[i*3+1].Name = $"=>{i+1}";
                inequalities[i*3+1].Size = new System.Drawing.Size(50, 20);
                inequalities[i*3+1].TabIndex = i*3+2;
                inequalities[i*3+1].Text = "=>";
                inequalities[i*3+1].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                inequalities[i * 3 + 1].Visible = false;
                this.Controls.Add(inequalities[i*3+1]);

                inequalities[i*3+2] = new System.Windows.Forms.Label();
                inequalities[i*3+2].Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                inequalities[i*3+2].Location = new System.Drawing.Point(430, 125+30*i);
                inequalities[i*3+2].Name = $"norm{i+1}";
                inequalities[i*3+2].Size = new System.Drawing.Size(160, 20);
                inequalities[i*3+2].TabIndex = i*3+3;
                inequalities[i*3+2].Text = "x"+InequalitiesFactory.Inequalities[i].NormalFormOperator+InequalitiesFactory.Inequalities[i].NormalFormC;
                inequalities[i*3+2].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                inequalities[i * 3 + 2].Visible = false;
                this.Controls.Add(inequalities[i*3+2]);
            }
            // 
            // ResultTitle
            // 
            this.resultTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.resultTitle.Location = new System.Drawing.Point(162, 295);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(277, 20);
            this.resultTitle.TabIndex = 0;
            this.resultTitle.Text = "Current result:";
            this.resultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            this.resultLable.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.resultLable.Location = new System.Drawing.Point(50, 325);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(520, 20);
            this.resultLable.TabIndex = 0;
            this.resultLable.Text = this.result.ToString();
            this.resultLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // nextButton
            //
            this.nextButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nextButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nextButton.Location = new System.Drawing.Point(400, 350);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(80, 35);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = InequalitiesFactory.Inequalities.Length>0?"Continue":"Close";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.Continue);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.iterationTitle);
            this.Controls.Add(this.resultTitle);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.nextButton);
            this.Name = "ResultForm";
            this.Text = "Inequalities Calculator";
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label iterationTitle;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Label[] inequalities;
        private Range result;
        private System.Windows.Forms.Button nextButton;

        #endregion
    }
}