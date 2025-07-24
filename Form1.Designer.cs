namespace Media_Player
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
            this.Open = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(459, 89);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(354, 144);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.Location = new System.Drawing.Point(35, 82);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(54, 29);
            this.fileLabel.TabIndex = 3;
            this.fileLabel.Text = "File";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(95, 91);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(334, 20);
            this.fileName.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(95, 144);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 6;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(230, 144);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 7;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "This simple media player uses Windows Media Player controls in order to play MP3\'" +
    "s. I am unsure if it plays other files.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Open selects a file, Play then plays it, Pauses will pause, and Exit ends the pro" +
    "gram";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Want to add: Library, Previous/Next, Stop, Attach progress bar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "MP3 Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

