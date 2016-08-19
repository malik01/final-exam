using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm splashForm = Program.splashscreen;
        public GenerateNameForm generateForm = Program.generateNameScreen;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashtimer_Tick(object sender, EventArgs e)
        {

            splashtimer.Enabled = false;
            generateForm.Show();
            this.Hide();
            
        }
    }
}
