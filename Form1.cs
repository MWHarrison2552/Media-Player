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
        private List<string> mediaFiles = new List<string>();
        private int currentFileIndex = -1;
        private string sharedFolderPath = @"D:\My Shared Folder";
        private bool isProgrammaticSelection = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder containing MP3 files";
                folderDialog.SelectedPath = sharedFolderPath;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    sharedFolderPath = folderDialog.SelectedPath;
                    LoadMediaFiles();
                    PopulateSongList();
                    if (mediaFiles.Count > 0)
                    {
                        currentFileIndex = 0;
                        PlayFileAtIndex(currentFileIndex);
                    }
                    else
                    {
                        MessageBox.Show("No media files found in the selected folder.");
                    }
                }
            }
        }

        private void PlayFileAtIndex(int index)
        {
            if (index >= 0 && index < mediaFiles.Count)
            {
                currentFileIndex = index;
                fileName.Text = Path.GetFileName(mediaFiles[index]);
                Player.URL = mediaFiles[index];
                Player.controls.play();

                isProgrammaticSelection = true;
                songListBox.SelectedIndex = index;
                isProgrammaticSelection = false;
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
            LoadMediaFiles();
            PopulateSongList();
        }

        private void LoadMediaFiles()
        {
            if (Directory.Exists(sharedFolderPath))
            {
                mediaFiles = Directory.GetFiles(sharedFolderPath, "*.mp3").ToList();
            }
            else
            {
                mediaFiles.Clear();
            }
        }

        private void PopulateSongList()
        {
            // Place the ListBox on the right side of the form
            int rightMargin = 20;
            int listBoxWidth = 300;
            int listBoxHeight = 300;
            int listBoxX = this.ClientSize.Width - listBoxWidth - rightMargin;
            int listBoxY = 50;

            songListBox.Location = new Point(listBoxX, listBoxY);
            songListBox.Size = new Size(listBoxWidth, listBoxHeight);

            songListBox.Items.Clear();
            foreach (var file in mediaFiles)
            {
                songListBox.Items.Add(Path.GetFileName(file));
            }
        }

        // Play the selected song when double-clicked
        private void songListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = songListBox.SelectedIndex;
            PlayFileAtIndex(index);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Player.controls.pause();                                            // Pauses the currently playing song
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (mediaFiles.Count == 0) return;
            currentFileIndex--;
            if (currentFileIndex < 0) currentFileIndex = mediaFiles.Count - 1;
            PlayFileAtIndex(currentFileIndex);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (mediaFiles.Count == 0) return;
            currentFileIndex++;
            if (currentFileIndex >= mediaFiles.Count) currentFileIndex = 0;
            PlayFileAtIndex(currentFileIndex);
        }

        private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isProgrammaticSelection)
            {
                PlayFileAtIndex(songListBox.SelectedIndex);
            }
        }
    }
}
