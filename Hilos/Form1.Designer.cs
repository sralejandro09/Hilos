namespace Hilos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            START = new Button();
            STOP = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(134, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 149);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // START
            // 
            START.Location = new Point(28, 406);
            START.Name = "START";
            START.Size = new Size(58, 32);
            START.TabIndex = 2;
            START.Text = "START";
            START.UseVisualStyleBackColor = true;
            START.Click += START_Click;
            // 
            // STOP
            // 
            STOP.Location = new Point(106, 406);
            STOP.Name = "STOP";
            STOP.Size = new Size(48, 30);
            STOP.TabIndex = 3;
            STOP.Text = "STOP";
            STOP.UseVisualStyleBackColor = true;
            STOP.Click += STOP_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(804, 449);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(STOP);
            Controls.Add(START);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button START;
        private Button STOP;
        private PictureBox pictureBox2;
    }
}
