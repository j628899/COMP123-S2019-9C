using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LC
{
    public partial class CoculateForm : Form
    {
        public CoculateForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Thus is the shared event handler for the CaculatorButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoculatorButtenEven(object sender, EventArgs e)
        {
            var TheButton = (Button)sender;
            int ButtonValue;
            bool Result = int.TryParse(TheButton.Text, out ButtonValue);
            if(Result)
            {
                ResultL.Text = TheButton.Text;
            }
            else
            {
                ResultL.Text = "Not a number";
            }

            
        }
    }
}
