using System;
using System.Drawing;
using System.Windows.Forms;
using VlaggenRefresh.Properties;

namespace VlaggenRefresh
{
    public partial class UserControl3 : UserControl
    {
        string[] Vlaggen = { "Argentinie", "France", "Germany", "Italy", "Lithuania", "Netherlands", "United_States", "Belgium", "Canada", "Japan" };
        string[] VlaggenPool = { };

        string theVlag = "";
        int round = 0;
        int correct = 0;
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

        private string[] FillPickPool()
        {
            string[] strarr = { };

            for (int i = 0; i < VlaggenPool.Length; i++)
            {
                strarr = TableInsert(strarr, VlaggenPool[i]);
            }

            return strarr;

        }
        private void Quiz(string vlag)
        {
            if (vlag != "")
                round++;
            if (vlag != "" && (vlag == theVlag))
            {
                correct++;
                MessageBox.Show("That's right!");
            }
            else if (vlag != "" && (vlag != theVlag))
                MessageBox.Show("That's incorrect!");

            string[] PickPool = {};

            if (VlaggenPool.Length > 2)
            {
                Random r = new Random();
                int ChosenVlag = r.Next(0, VlaggenPool.Length);
                string rVlag = VlaggenPool[ChosenVlag];
                theVlag = rVlag;
                VlaggenPool = TableRemove(VlaggenPool, ChosenVlag);
                PickPool = FillPickPool();
                int WhereToPlace = r.Next(1, 4);
                for (int i = 1; i < 4; i++)
                {
                    if (WhereToPlace != i)
                    {
                        int rInt = r.Next(0, PickPool.Length);
                        rVlag = PickPool[rInt];
                        PickPool = TableRemove(PickPool, rInt);
                        PictureBox pic = Find_Vlag(i);
                        object O = Resources.ResourceManager.GetObject(rVlag);
                        pic.Image = (Image)O;
                        pic.Image.Tag = rVlag; 
                    }
                    else
                    {
                        PictureBox pic = Find_Vlag(i);
                        object O = Resources.ResourceManager.GetObject(theVlag);
                        pic.Image = (Image)O;
                        pic.Image.Tag = theVlag;
                    }
                }

                if(theVlag == "United_States")
                    Label_QuizQuestion.Text = "Which flag is of United States?";
                else
                    Label_QuizQuestion.Text = "Which flag is of " + theVlag + "?";
            }
            else
            {
                this.Visible = false;
                MessageBox.Show("You got " + correct.ToString() + " out of " + round.ToString() + " correct");
                MessageBox.Show("End of quiz");
            }
        }

        private void UserControl3_VisibleChanged(object sender, EventArgs e)
        {
            UserControl user = (sender as UserControl);
            if (user.Visible)
            {
                round = 0;
                correct = 0;
                while (VlaggenPool.Length > 0)
                    VlaggenPool = TableRemove(VlaggenPool, 0);
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
