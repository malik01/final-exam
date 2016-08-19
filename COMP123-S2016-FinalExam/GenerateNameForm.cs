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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }
        //public string GenerateNames()
        //{
            //List<>
             //rnd = new Random();
            //string rndname = Convert.ToString(rnd.Next(firstname));
            //rndname = FirstNameTextBox.Text;
            //return Convert.ToString(rndname);
        //}
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //GenerateNames();
            //Program.character.FirstName = FirstNameTextBox.Text;
            //Program.character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
        }
    }
}
