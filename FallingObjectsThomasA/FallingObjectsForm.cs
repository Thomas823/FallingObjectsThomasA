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
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void btnCalculateAnswer_Click(object sender, EventArgs e)
        {
            //Create an Answer variable. We use a double to allow for decimals
            double answer;

            //Take string from text box (Time variable we need), and convert it to a double and store in answer variable
            answer = double.Parse(txtAnswerInput.Text);

            //Calculate Answer and make it a string to display
            lblAnswer.Text = Convert.ToString(100 - 0.5 * 9.8 * Math.Pow(answer, 2));
        }
    }
}
