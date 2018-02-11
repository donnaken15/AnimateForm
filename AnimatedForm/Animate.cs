using System;
using System.Windows.Forms;

namespace AnimatedForm
{
    public partial class Animate : Form
    {
        public Animate()
        {
            InitializeComponent();
        }

        private void increasesize1_Click(object sender, EventArgs e)
        {
            if (400 > Width | 333 > Height)
            {
                testlabel.Text = "It works!";
            }
            AnimateForm.AnimateResize(this, 640, 480, Convert.ToInt16(sped.Value));
        }

        private void decreasesize1_Click(object sender, EventArgs e)
        {
            AnimateForm.AnimateResize(this, 160, 120, Convert.ToInt16(sped.Value));
            testlabel.Text = "CHEATER!";
        }

        private void normalsize1_Click(object sender, EventArgs e)
        {
            AnimateForm.AnimateResize(this, 320, 240, Convert.ToInt16(sped.Value));
            testlabel.Text = "CHEATER!";
        }
    }
}
