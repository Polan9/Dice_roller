﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dice_methods;


namespace Dice_roll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Roll_button_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            List<PictureBox> pic_boxes = new List<PictureBox>();
            pic_boxes.Add(pictureBox2);
            pic_boxes.Add(pictureBox1);
            pic_boxes.Add(pictureBox3);


            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 3;
            int dice_amount = (int)numericUpDown1.Value;
            for (int i = 0; i < dice_amount; i++)  { 
            
                dice.Roll_number();
                dice.Display_number(pic_boxes[i]);
            }
        }




    }
}
