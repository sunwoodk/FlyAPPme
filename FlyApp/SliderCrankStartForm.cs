using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyApp
{
    public partial class SliderCrankStartForm : Form
    {
        public SliderCrankStartForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            SliderCrankInputForm inputForm = new SliderCrankInputForm();
            inputForm.Show();
        }
    }
}
