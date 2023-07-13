namespace WinFormsApp1
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
            pictureBoxDog = new PictureBox();
            buttonFetchDog = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDog
            // 
            pictureBoxDog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxDog.Location = new Point(0, 0);
            pictureBoxDog.MaximumSize = new Size(1024, 1024);
            pictureBoxDog.Name = "pictureBoxDog";
            pictureBoxDog.Padding = new Padding(10);
            pictureBoxDog.Size = new Size(800, 450);
            pictureBoxDog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDog.TabIndex = 0;
            pictureBoxDog.TabStop = false;
            // 
            // buttonFetchDog
            // 
            buttonFetchDog.BackColor = SystemColors.MenuText;
            buttonFetchDog.Dock = DockStyle.Bottom;
            buttonFetchDog.ForeColor = SystemColors.ButtonFace;
            buttonFetchDog.Location = new Point(0, 403);
            buttonFetchDog.Name = "buttonFetchDog";
            buttonFetchDog.Padding = new Padding(5);
            buttonFetchDog.Size = new Size(800, 47);
            buttonFetchDog.TabIndex = 1;
            buttonFetchDog.Text = "Random Dog";
            buttonFetchDog.UseVisualStyleBackColor = false;
            buttonFetchDog.Click += buttonFetchDog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFetchDog);
            Controls.Add(pictureBoxDog);
            Name = "Form1";
            Text = "Random Dogs";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxDog;
        private Button buttonFetchDog;
    }
}