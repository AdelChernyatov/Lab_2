using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        private Patient pat;
        private string name;
        private string first_name;
        private string date;
        private int id;
        private string male_m;
        private string male_w;
        private string diagnoz;
        private DataGridView view;
        public Form2()
        {
            InitializeComponent();
        }
        
        public void Initialize(DataGridView data)
        {
            view = data;
            
        }

        private void Name_2text_TextChanged(object sender, EventArgs e)
        {
            name = this.Name_2text.Text;
        }

        private void FirName_text_TextChanged(object sender, EventArgs e)
        {
            first_name = this.FirName_text.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            male_m = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            male_w = radioButton2.Text;
        }

        private void data_text_TextChanged(object sender, EventArgs e)
        {
            date =data_text.Text;
                
        }

        private void id_Box_TextChanged(object sender, EventArgs e)
        {
            id = int.Parse(id_Box.Text);
        }

        private void diagnos_richText_TextChanged(object sender, EventArgs e)
        {
            diagnoz = diagnos_richText.Text;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (male_m != null)
                {
                    pat = new Patient(id, name, first_name, DateTime.Parse(date), male_m, diagnoz, " ");
                }
                else { pat = new Patient(id, name, first_name, DateTime.Parse(date), male_w, diagnoz, " "); }
                view.Rows.Add(pat.id, pat.Name, pat.First_Name, pat.date, pat.male);
                this.Close();
            }
            catch { Console.WriteLine("Ввод данных вами не корректен"); }

        }
    }
}
