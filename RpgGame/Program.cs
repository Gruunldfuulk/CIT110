using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgGame
{
    static class Program
    {
        //***********************************
        //Title: RPG Game (Dungeon)
        //Application Type: WinForms
        //Description: (describe the purpose and function)
        //Author: Alexandru Juhasz
        //Date Created: 11/30/2018
        //Last Modified: 12/09/2018
        //************************************

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Menu());
        }
    }
}
