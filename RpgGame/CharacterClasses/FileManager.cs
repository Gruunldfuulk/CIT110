using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RpgGame.CharacterClasses
{
    class FileManager
    {
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
        private static Player DefaultPlayer
        {
            get
            {
                return new Player
                {
                    Name = "",
                    Gender = EntityGender.Unknown,
                    CharacterClass = EntityClass.Unknown,
                    Physique = 0,
                    Cunning = 0,
                    Spirit = 0,
                    Health = 0,
                    Energy = 0,
                };
               
            }
        }
        public static Player LoadPlayer()
        {
            if (!File.Exists(SettingsFile))
                return DefaultPlayer;
            using (Stream stream = File.OpenRead(SettingsFile))
                {
                XmlSerializer ser = new XmlSerializer(typeof(Player));
                return (Player)ser.Deserialize(stream);
                }
        }
        public static void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(SettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }
    }
}
