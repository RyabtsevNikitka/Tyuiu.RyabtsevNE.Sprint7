namespace Tyuiu.RyabtsevNE.Sprint7.Project.V2
{
    partial class MyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            panel1 = new Panel();
            labelclick = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(labelclick);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 226);
            panel1.TabIndex = 0;
            // 
            // labelclick
            // 
            labelclick.AutoSize = true;
            labelclick.FlatStyle = FlatStyle.Flat;
            labelclick.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelclick.ForeColor = Color.White;
            labelclick.Location = new Point(449, 188);
            labelclick.Name = "labelclick";
            labelclick.Size = new Size(78, 15);
            labelclick.TabIndex = 3;
            labelclick.Text = "Продолжить";
            labelclick.Click += labelclick_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(331, 9);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 2;
            label2.Text = "Обо мне";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(239, 107);
            label1.Name = "label1";
            label1.Size = new Size(231, 42);
            label1.TabIndex = 1;
            label1.Text = "Рябцев Никита Евгеньевич\r\nСМАРТб-24-1\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 226);
            Controls.Add(panel1);
            Name = "MyForm";
            Text = "MyForm";
            Load += MyForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelclick;
    }
}