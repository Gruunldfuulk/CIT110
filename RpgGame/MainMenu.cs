using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgGame
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            Frm_CharacterCreator characterCreator = new Frm_CharacterCreator();
            characterCreator.Show();
        }

        private void Btn_Options_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Credits_Click(object sender, EventArgs e)
        {

        }


    }
}
