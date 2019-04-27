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
    public partial class UserControl3 : UserControl
    {
        string[] Vlaggen = { "Argentinie", "France", "Germany", "Italy", "Lithuania", "Netherlands", "United_States", "Belgium", "Canada", "Japan" };
        string[] VlaggenPool = {};
        
        string theVlag = "";

        public UserControl3()
        {
            InitializeComponent();
        }

        private string[] TableInsert(string[] arr, string str)
        {
            String[] arr2 = new String[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[arr2.Length - 1] = str;
            return arr2;
        }

        private string[] TableRemove(string[] arr, int index)
        {
            String[] arr2 = new String[arr.Length - 1];
            int off = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                    arr2[i - off] = arr[i];
                else
                    off++;
            }
            return arr2;
        }

        private PictureBox Find_Vlag(int rInt)
        {
            PictureBox thePic = null;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    if ((pic.Tag != null) && (pic.Tag.ToString() == rInt.ToString()))
                    {
                        thePic = pic;
                        break;
                    }
                }
            }
            return thePic;
        }

        private void Quiz(string vlag)
        {
            if (vlag != "" && (vlag == theVlag))
                MessageBox.Show("That's right!");
            else if (vlag != "" && (vlag != theVlag))
                MessageBox.Show("That's incorrect!");

            if (VlaggenPool.Length > 3)
            {
                Random r = new Random();
                int pick = r.Next(1, 4);
                for (int i = 1; i < 4; i++)
                {
                    int rInt = r.Next(0, VlaggenPool.Length);
                    string rVlag = VlaggenPool[rInt];
                    PictureBox pic = Find_Vlag(i);
                    object O = Resources.ResourceManager.GetObject(rVlag);
                    pic.Image = (Image)O;
                    pic.Image.Tag = rVlag;
                    if (i == pick)
                        theVlag = rVlag;
                    VlaggenPool = TableRemove(VlaggenPool, rInt);
                }

                if(theVlag == "United_States")
                    Label_QuizQuestion.Text = "Which flag is of United States?";
                else
                    Label_QuizQuestion.Text = "Which flag is of " + theVlag + "?";
            }
            else
            {
                this.Visible = false;
                MessageBox.Show("End of quiz");
            }
        }

        private void UserControl3_VisibleChanged(object sender, EventArgs e)
        {
            UserControl user = (sender as UserControl);
            if (user.Visible)
            {
                for (int i = 0; i < Vlaggen.Length; i++)
                {
                    VlaggenPool = TableInsert(VlaggenPool, Vlaggen[i]);
                }
                Quiz("");
            }
        }

        private void OnVlagClicked(object sender, EventArgs e)
        {
            PictureBox user = (sender as PictureBox);
            Quiz(user.Image.Tag.ToString());
        }
    }
}
