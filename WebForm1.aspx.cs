using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyChallange2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int firstValue;
            firstValue = Convert.ToInt32(firstTextBox.Text);
            firstValue = int.Parse(firstTextBox.Text);

            int secondValue;
            secondValue = Convert.ToInt32(secondTextBox.Text);
            secondValue = int.Parse(secondTextBox.Text);

            int result = firstValue + secondValue;

            resultLabel.Text = result.ToString();
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            int firstValue;
            firstValue = Convert.ToInt32(firstTextBox.Text);
            firstValue = int.Parse(firstTextBox.Text);

            int secondValue;
            secondValue = Convert.ToInt32(secondTextBox.Text);
            secondValue = int.Parse(secondTextBox.Text);

            int result = firstValue - secondValue;

            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstValue;
            firstValue = Convert.ToInt32(firstTextBox.Text);
            firstValue = int.Parse(firstTextBox.Text);

            int secondValue;
            secondValue = Convert.ToInt32(secondTextBox.Text);
            secondValue = int.Parse(secondTextBox.Text);

            int result = firstValue * secondValue;

            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            int firstValue;
            firstValue = Convert.ToInt32(firstTextBox.Text);
            firstValue = int.Parse(firstTextBox.Text);

            int secondValue;
            secondValue = Convert.ToInt32(secondTextBox.Text);
            secondValue = int.Parse(secondTextBox.Text);

            int result = firstValue / secondValue;

            resultLabel.Text = result.ToString();
        }
    }
}