using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VlaggenRefresh.Properties;

namespace VlaggenRefresh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void Btn_Nav_vlaggen_Click(object sender, EventArgs e)
        {
            if (Btn_Nav_vlaggen.Text == "Bekijk vlaggen")
            {
                Btn_Nav_Start_Quiz.Visible = false;
                userControl11.Hide();
                userControl21.Show();
                Btn_Nav_vlaggen.Text = "Terug";
            }
            else
            {
                Btn_Nav_Start_Quiz.Visible = true;
                userControl21.Hide();
                userControl11.Show();
                Btn_Nav_vlaggen.Text = "Bekijk vlaggen";
            }
        }

        private void Btn_Nav_Start_Quiz_Click(object sender, EventArgs e)
        {
            if (Btn_Nav_Start_Quiz.Text == "Start Quiz")
            {
                Btn_Nav_vlaggen.Visible = false;
                userControl11.Hide();
                userControl31.Show();
                Btn_Nav_Start_Quiz.Text = "Terug";
            }
            else
            {
                Btn_Nav_vlaggen.Visible = true;
                userControl31.Hide();
                userControl11.Show();
                Btn_Nav_Start_Quiz.Text = "Start Quiz";
            }
        }

    }
}
