using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Dice_methods
{


    public class Dice
    {
        public Random rnd = new Random();
        public int rolled_number;

        public void Roll_number()
        {
            rolled_number = rnd.Next(1,6);
            Console.WriteLine($"Rolled {rolled_number}");
        } 
        
        public void Display_number(PictureBox box)
        {
            string image_path = Path.Combine(Application.StartupPath,"images", $"dice_{rolled_number}.png");
            box.Image = Image.FromFile(image_path);
        }
    }









}





namespace Dice_roll
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
