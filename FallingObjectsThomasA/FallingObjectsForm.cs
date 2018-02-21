using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsThomasA
{
    public partial class frmFallingObjects : Form
    {
        //Create a finalAnswer, InputTime, and InputHeight variable. We use a double to allow for decimals.
        double userInputTime;
        double userInputHeight;
        double finalAnswer;

        public frmFallingObjects()
        {
            InitializeComponent();

            //Hide the answerprompt and answer 
            this.lblAnswerPrompt.Hide();
            this.lblFinalAnswer.Hide();
        }

        private void btnCalculateAnswer_Click(object sender, EventArgs e)
        {
            //Take string from height and time text box, and convert it to a double
            userInputHeight = double.Parse(txtInputHeight.Text);
            userInputTime = double.Parse(txtInputTime.Text);

            //Calculate Answer (H = StartHeight - 0.5 * g * t^2) and round by two decimal places
            finalAnswer = userInputHeight - 0.5 * 9.8 * Math.Pow(userInputTime, 2);
            finalAnswer = finalAnswer * 100;
            finalAnswer = Math.Round(finalAnswer);
            finalAnswer = finalAnswer / 100;

            //Convert to a string to display
            lblFinalAnswer.Text = Convert.ToString(finalAnswer) + " meters";

            //If object has already hit the ground
            if (userInputHeight - 0.5 * 9.8 * Math.Pow(userInputTime, 2) < 0)
            {
                lblFinalAnswer.Text = "You have already hit the ground!";
            }

            //If object starts on the ground
            if (userInputHeight == 0)
            {
                lblFinalAnswer.Text = "You are already on the ground!";
            }

            //Show the answerprompt and answer
            this.lblAnswerPrompt.Show();
            this.lblFinalAnswer.Show();
        }
    }
}
