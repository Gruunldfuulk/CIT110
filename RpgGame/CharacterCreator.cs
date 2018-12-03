using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgGame.CharacterClasses;

namespace RpgGame
{
    public partial class Frm_CharacterCreator : Form
    {
        public Frm_CharacterCreator()
        {
            InitializeComponent();
        }

        private void Btn_SaveCharacter_Click(object sender, EventArgs e)
        {
            //Wizard player1 = new Wizard();

            //MessageBox.Show("You have a new Wizard with a stregth of" + player1.Strength.ToString() + ".", "New Wizard");


            // make sure the user picks a name
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) || 
                   Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character.");
                    return;
            }

            // make sure the user picks a gender
            if (this.Rdo_GenderMale.Checked == false && this.Rdo_GenderFemale.Checked == false)
            {
                MessageBox.Show("You must select a gender.");
                return;
            }
            string gender = (string)(this.Rdo_GenderMale.Checked ? "Male" : "Female");
            //show output
            //MessageBox.Show(output);
        }
    }
}
