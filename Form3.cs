using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form3 : Form
    {
        private int id;
        private string history;
        public Form3()
        {
            InitializeComponent();
            
        }
        public void Inizialization(string name,int id,string history,string diagnos)
        {
            this.id = id;
            this.history = history;
            pictureBox1_();
            richTextBox1.Text = diagnos;
            text_Name.Text = name;
        }
        
        private void pictureBox1_() 
        {
            switch (id)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@".\..\..\Resources\1.JPG");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@".\..\..\Resources\2.JPG");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@".\..\..\Resources\3.JPG");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@".\..\..\Resources\4.JPG");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(@".\..\..\Resources\5.JPG");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;

            }
        }
        private void tabControl2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = history;
        }
    }
}
