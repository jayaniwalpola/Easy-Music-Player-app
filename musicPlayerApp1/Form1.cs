using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlayerApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select song
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select ,ultiple songs
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;//save the name of the track in files array
                paths = ofd.FileNames;//save the path of the track in path aaaray
                                      //display the music titles in the list box

                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);//display songs in list box
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
