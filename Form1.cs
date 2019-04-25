using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marc_sPlayer
{
    public partial class Marc_sPlayer : Form
    {
        public Marc_sPlayer()
        {
            InitializeComponent();
        }

        //Create Global Variables of String Type Array to save the titles or the name of the Tracks and path of the track
        String[] paths, files;

        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to Select Songs
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                //Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display Songs in Listbox
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play music
            WindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
