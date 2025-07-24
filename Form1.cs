/*
 * Simple media player using WMPlib as a reference. I believe it does not work if windows media player is not installed on the computer. 
 * As far as I know the WMP controls only play MP3's. I am not sure what else it plays, if anything.
 * 
 */ 


using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Security.Cryptography.X509Certificates;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();     // Create "Player" object from wmp libray.
        public Form1()
        {
            InitializeComponent();
        }
        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {

                open.InitialDirectory = "C:\\";                                 // Default starting directory
                open.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";    // Acceptable files in file types drop down
                open.FilterIndex = 1;                                           // Which file type the filter starts in. MP3 or All Files in this case.
                open.RestoreDirectory = true;                                   // Starts on the directory the user ended on last.

                if (open.ShowDialog() == DialogResult.OK)
                {
                    fileName.Text = Path.GetFileName(open.FileName);            // Sets only the file name instead of the full path in the text box
                    Player.URL = open.FileName;                                 // Sets Player object path 
                }

                }
        }

        // Play button.
        private void Play_Click(object sender, EventArgs e)
        {
           // Player.URL = path;                                                  
            Player.controls.play();                                             // Plays the selected file
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Player.controls.pause();                                            // Pauses the currently playing song
        }
    }
}
