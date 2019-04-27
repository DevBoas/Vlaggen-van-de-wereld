namespace VlaggenRefresh
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_Nav_vlaggen = new System.Windows.Forms.Button();
            this.Btn_Nav_Start_Quiz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl31 = new VlaggenRefresh.UserControl3();
            this.userControl21 = new VlaggenRefresh.UserControl2();
            this.userControl11 = new VlaggenRefresh.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Btn_Nav_vlaggen
            // 
            this.Btn_Nav_vlaggen.Location = new System.Drawing.Point(12, 301);
            this.Btn_Nav_vlaggen.Name = "Btn_Nav_vlaggen";
            this.Btn_Nav_vlaggen.Size = new System.Drawing.Size(112, 23);
            this.Btn_Nav_vlaggen.TabIndex = 4;
            this.Btn_Nav_vlaggen.Text = "Bekijk vlaggen";
            this.Btn_Nav_vlaggen.UseVisualStyleBackColor = true;
            this.Btn_Nav_vlaggen.Click += new System.EventHandler(this.Btn_Nav_vlaggen_Click);
            // 
            // Btn_Nav_Start_Quiz
            // 
            this.Btn_Nav_Start_Quiz.Location = new System.Drawing.Point(360, 301);
            this.Btn_Nav_Start_Quiz.Name = "Btn_Nav_Start_Quiz";
            this.Btn_Nav_Start_Quiz.Size = new System.Drawing.Size(112, 23);
            this.Btn_Nav_Start_Quiz.TabIndex = 5;
            this.Btn_Nav_Start_Quiz.Text = "Start Quiz";
            this.Btn_Nav_Start_Quiz.UseVisualStyleBackColor = true;
            this.Btn_Nav_Start_Quiz.Click += new System.EventHandler(this.Btn_Nav_Start_Quiz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl31);
            this.panel1.Controls.Add(this.userControl21);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 283);
            this.panel1.TabIndex = 6;
            // 
            // userControl31
            // 
            this.userControl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl31.Location = new System.Drawing.Point(0, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(460, 283);
            this.userControl31.TabIndex = 2;
            this.userControl31.Visible = false;
            // 
            // userControl21
            // 
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(460, 283);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(460, 283);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Nav_Start_Quiz);
            this.Controls.Add(this.Btn_Nav_vlaggen);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vlaggen van de wereld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Btn_Nav_vlaggen;
        private System.Windows.Forms.Button Btn_Nav_Start_Quiz;
        private System.Windows.Forms.Panel panel1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
    }
}

