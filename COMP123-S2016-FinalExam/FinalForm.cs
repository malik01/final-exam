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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //loads all the properties from the character class to the final form
        private void FinalForm_Load(object sender, EventArgs e)
        {
            DexterityTextBox.Text = Program.character.Dexterity;
            StrengthTextBox.Text = Program.character.Strength;
            ConstitutionTextBox.Text = Program.character.Constitution;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Charisma;
            RaceTextBox.Text = Program.character.Race;
            FirstNameTextbox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            
        }

    }
}
