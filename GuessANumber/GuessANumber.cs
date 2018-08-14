/*Zachary Miller
 * 01/10/2018
 * assignment 8.2
 * The purpose of this program is play a guessing game with radio buttons. You must guess which button is the correct one
 * GuessANumber.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber
{
    static class GuessANumber
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
