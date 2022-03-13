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
    public partial class Form1 : Form
    {
        public static string[] history = File.ReadAllLines(@".\..\..\Data\history.txt");
        private List<Patient> patientList = new List<Patient>();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();    
        }
       
        Patient pat1 = new Patient(1,"Адель","Чернятов",new DateTime(2003,02,16),"м","Простуда",history[0]);
        Patient pat2 = new Patient(2, "Илья", "Игуменов", new DateTime(2003, 09, 19), "м","Грипп",history[1]);
        Patient pat3 = new Patient(3, "Ринат", "Кучаев", new DateTime(2003, 07, 21), "м","Нет диагноза",history[2]);
        Patient pat4 = new Patient(4, "Булат", "Хасанов", new DateTime(2003, 01, 10), "м","Корона",history[3]);
        Patient pat5 = new Patient(5, "Никита", "Макурин", new DateTime(2003, 04, 14), "м","Ангина",history[4]);
        internal void InitializeDataGridView()
        {
            dataGridView1.Rows.Add(pat1.id,pat1.Name,pat1.First_Name,pat1.date,pat1.male);         
            dataGridView1.Rows.Add(pat2.id, pat2.Name, pat2.First_Name, pat2.date, pat2.male);         
            dataGridView1.Rows.Add(pat3.id, pat3.Name, pat3.First_Name, pat3.date, pat3.male);           
            dataGridView1.Rows.Add(pat4.id, pat4.Name, pat4.First_Name, pat4.date, pat4.male);           
            dataGridView1.Rows.Add(pat5.id, pat5.Name, pat5.First_Name, pat5.date, pat5.male);
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells[dataGridView1.SelectedCells.Count - 1].RowIndex + 1 == 1)
            {
              this.Name_text.Text = (pat1.Name + " " + pat1.First_Name);
              this.male_text.Text = pat1.male;
              this.age_text.Text = pat1.GetAge(pat1.date).ToString();
              this.pictureBox.Image = Image.FromFile(@".\..\..\Resources\1.JPG");
              this.id_2text.Text = pat1.id.ToString();
              pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (dataGridView1.SelectedCells[dataGridView1.SelectedCells.Count - 1].RowIndex + 1 == 2)
            {
              this.Name_text.Text = (pat2.Name + " " + pat2.First_Name);
              this.male_text.Text = pat2.male;
              this.age_text.Text = pat2.GetAge(pat2.date).ToString();
              this.pictureBox.Image = Image.FromFile(@".\..\..\Resources\2.JPG");
              this.id_2text.Text = pat2.id.ToString();
              pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            }
            else if (dataGridView1.SelectedCells[dataGridView1.SelectedCells.Count - 1].RowIndex + 1 == 3)
            {
              this.Name_text.Text = (pat3.Name + " " + pat3.First_Name);
              this.male_text.Text = pat3.male;
              this.age_text.Text = pat3.GetAge(pat3.date).ToString();
              this.pictureBox.Image = Image.FromFile(@".\..\..\Resources\3.JPG");
              this.id_2text.Text = pat3.id.ToString();
              pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            }
            else if (dataGridView1.SelectedCells[dataGridView1.SelectedCells.Count - 1].RowIndex + 1 == 4)
            {
              this.Name_text.Text = (pat4.Name + " " + pat4.First_Name);
              this.male_text.Text = pat4.male;
              this.age_text.Text = pat1.GetAge(pat4.date).ToString();
              this.pictureBox.Image = Image.FromFile(@".\..\..\Resources\4.JPG");
              this.id_2text.Text = pat4.id.ToString();
              pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    
            }
            else if (dataGridView1.SelectedCells[0].RowIndex + 1 == 5)
            {
              this.Name_text.Text = (pat5.Name + " " + pat5.First_Name);
              this.male_text.Text = pat5.male;
              this.age_text.Text = pat5.GetAge(pat5.date).ToString();
              this.pictureBox.Image = Image.FromFile(@".\..\..\Resources\5.JPG");
              this.id_2text.Text = pat5.id.ToString();
              pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.Initialize(dataGridView1);
        }
        private void info_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            if (id_2text.Text.Equals("1"))
            {
                f3.Inizialization(this.Name_text.Text, pat1.id,pat1.history,pat1.diagnoz);
            }
            else if(id_2text.Text.Equals("2"))
            {
                f3.Inizialization(this.Name_text.Text, pat2.id, pat2.history, pat2.diagnoz);
            }
            else if(id_2text.Text.Equals("3"))
            {
                f3.Inizialization(this.Name_text.Text, pat3.id, pat3.history, pat3.diagnoz);
            }
            else if (id_2text.Text.Equals("4"))
            {
                f3.Inizialization(this.Name_text.Text, pat4.id, pat4.history, pat4.diagnoz);
            }
            else if (id_2text.Text.Equals("5"))
            {
                f3.Inizialization(this.Name_text.Text, pat5.id, pat5.history, pat5.diagnoz);
            }

        }
 
    }
}
