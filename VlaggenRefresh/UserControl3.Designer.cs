namespace VlaggenRefresh
{
    partial class UserControl3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Label_QuizQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic2
            // 
            this.Pic2.Image = global::VlaggenRefresh.Properties.Resources.Germany;
            this.Pic2.Location = new System.Drawing.Point(185, 112);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(100, 70);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 1;
            this.Pic2.TabStop = false;
            this.Pic2.Tag = "2";
            this.Pic2.Click += new System.EventHandler(this.OnVlagClicked);
            // 
            // Pic3
            // 
            this.Pic3.Image = global::VlaggenRefresh.Properties.Resources.Netherlands;
            this.Pic3.Location = new System.Drawing.Point(333, 112);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(100, 70);
            this.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic3.TabIndex = 2;
            this.Pic3.TabStop = false;
            this.Pic3.Tag = "3";
            this.Pic3.Click += new System.EventHandler(this.OnVlagClicked);
            // 
            // Pic1
            // 
            this.Pic1.Image = global::VlaggenRefresh.Properties.Resources.France;
            this.Pic1.Location = new System.Drawing.Point(35, 112);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(100, 70);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 3;
            this.Pic1.TabStop = false;
            this.Pic1.Tag = "1";
            this.Pic1.Click += new System.EventHandler(this.OnVlagClicked);
            // 
            // Label_QuizQuestion
            // 
            this.Label_QuizQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_QuizQuestion.Location = new System.Drawing.Point(32, 33);
            this.Label_QuizQuestion.Name = "Label_QuizQuestion";
            this.Label_QuizQuestion.Size = new System.Drawing.Size(401, 27);
            this.Label_QuizQuestion.TabIndex = 5;
            this.Label_QuizQuestion.Text = "Which flag is of X?";
            this.Label_QuizQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_QuizQuestion);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic2);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.UserControl3_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.PictureBox Pic3;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Label Label_QuizQuestion;
    }
}
