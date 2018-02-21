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

        //Create repeat variables
        int repeat;
        int repeatTimes;

        public frmFallingObjects()
        {
            InitializeComponent();

            //Hide the answerprompt, answer, and approximate height notifer
            this.lblAnswerPrompt.Hide();
            this.lblFinalAnswer.Hide();
            this.lblApproximateHeightNotifier.Hide();
        }

        private void btnCalculateAnswer_Click(object sender, EventArgs e)
        {
            //Reset image location, set to rock image, make sure repeat functions are set to 0 each time. Also hide the approximate height notifier and final answer
            picRock.Image = Properties.Resources.Rock;
            picRock.Location = new Point(921, 27);
            repeatTimes = 0;
            repeat = 0;
            this.lblApproximateHeightNotifier.Hide();
            this.lblFinalAnswer.Hide();

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

            //If it's a normal calculatios, Set repeatTimes to 45 to make the rock go in the middle.
            repeatTimes = 45;

            //If object has already hit the ground, tell the user and change the rock to move all the way down
            if (userInputHeight - 0.5 * 9.8 * Math.Pow(userInputTime, 2) < 0)
            {
                lblFinalAnswer.Text = "You have already hit the ground!";
                repeatTimes = 90;
            }

            //If object starts on the ground, tell the user and change the rock to move to the ground right away
            if (userInputHeight == 0)
            {
                lblFinalAnswer.Text = "You are already on the ground!";
                repeatTimes = 0;
                picRock.Location = new Point(921, 350);
            }

            //If no time was given, the height will be the same!
            if (userInputTime == 0)
            {
                lblFinalAnswer.Text = "You didn't move!";
                repeatTimes = 0;
            }

            //Show the answerprompt and answer
            this.lblAnswerPrompt.Show();
            this.lblFinalAnswer.Show();

            //Move Rock down by repeating by the number set above. 
            while (repeat < repeatTimes)
            {
                //Move rock down 3 pixels
                picRock.Top += 3;

                //Cause a 5ms delay to make the rock seem like its "moving"
                System.Threading.Thread.Sleep(5);

                //Increment the repeat function
                repeat = repeat + 1;
            }

            //Show approximate height notifier if the rock was set to the middle (45), after the rock has moved
            if (repeatTimes == 45)
            {
                this.lblApproximateHeightNotifier.Show();
            }

            //If the object has hit the ground, change the rock image to an explosion after the rock has moved
            if (repeatTimes == 90)
            {
                picRock.Image = Properties.Resources.Explosion;
            }
        }
    }
}
