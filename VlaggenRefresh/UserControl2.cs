using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VlaggenRefresh.Properties;

namespace VlaggenRefresh
{
    public partial class UserControl2 : UserControl
    {
        string[] Vlaggen = { "Argentinie", "France", "Germany", "Italy", "Lithuania", "Netherlands", "United_States", "Belgium", "Canada", "Japan" };

        private void PopulateVlags()
        {
            for (int i = 0; i < Vlaggen.Length; i++)
            {
                PictureBox pic = new PictureBox();
                object O = Resources.ResourceManager.GetObject(Vlaggen[i]);
                pic.Image = (Image)O;
                pic.Size = new Size(100, 70);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.Controls.Add(pic);
            }
        }

        public UserControl2()
        {
            InitializeComponent();
            PopulateVlags();
        }
    }
}
