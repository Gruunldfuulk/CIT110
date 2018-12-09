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
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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
            string name;

            // make sure the user picks a name
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) || 
                   Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character.");
                    return;
            }
            name = this.Txt_CharacterName.Text;

            //Check the gender
            EntityGender eGender;
            if (this.Rdo_GenderMale.Checked)
                eGender = EntityGender.Male;
            else if (this.Rdo_GenderFemale.Checked)
                eGender = EntityGender.Female;
            else
            {
                MessageBox.Show("You must select a gender.");
                return;
            }

            // check the class
            EntityClass eClass;
            if (this.Cbo_CharacerClass.Text == "Wizard")
                eClass = EntityClass.Wizard;
            else if (this.Cbo_CharacerClass.Text == "Cleric")
                eClass = EntityClass.Cleric;
            else if (this.Cbo_CharacerClass.Text == "Rogue")
                eClass = EntityClass.Rogue;
            else if (this.Cbo_CharacerClass.Text == "Fighter")
                eClass = EntityClass.Fighter;
            else
            {
                MessageBox.Show("You must choose a class");
                return;
            }

            //Create the player
            Player player1 = new Player(name, eGender, eClass);

           string output;
            output = String.Format(
                "You created a new character.\n" +
                "Your name is: {0}\nYour gender is: {1}\n" +
                "Your class is: {2}.\nYour Physique is: {3}\n" +
                "Your Cunning is: {4}\n" + "Your Spirit is: {5}\n" +
                "Your Health is: {6}\n" + "Your Energy is: {7}\n", 
                player1.Name,
                player1.Gender.ToString(),
                player1.CharacterClass.ToString(),
                player1.Physique.ToString(),
                player1.Cunning.ToString(),
                player1.Spirit.ToString(),
                player1.Health.ToString(),
                player1.Energy.ToString());
            MessageBox.Show(output, "Success");
            StoreCharacter(player1);
            CharacterStats stats = new CharacterStats();
            stats.Show();
            this.Close();
        }
        private void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(SettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }

        private static String SettingsFolder
        {
            get
            { //create a string folder
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                //add a sub folder
                folder = Path.Combine(folder, "Rpg Game");
                folder = Path.Combine(folder, "Character Settings");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }
        private static String SettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "Player.xml");
            }
        }

    }
}
