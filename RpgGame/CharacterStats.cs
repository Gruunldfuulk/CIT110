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
    public partial class CharacterStats : Form
    {
        public CharacterStats()
        {
            InitializeComponent();
        }

        private void CharacterStats_Load(object sender, EventArgs e)
        {
            Player p1 = new Player();
            p1 = FileManager.LoadPlayer();
            Lbl_CharacterName.Text = p1.Name;
            Lbl_Gender.Text = p1.Gender.ToString();
            Lbl_CharacterClass.Text = p1.CharacterClass.ToString();
            Lbl_CharacterPhys.Text = p1.Physique.ToString();
            Lbl_CharacterCunning.Text = p1.Cunning.ToString();
            Lbl_CharacterSpirit.Text = p1.Spirit.ToString();
            Lbl_CharacterHealth.Text = p1.Health.ToString();
            Lbl_CharacterEnergy.Text = p1.Energy.ToString();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Frm_Menu home = new Frm_Menu();
            home.Show();
            this.Hide();
        }
    }
}
