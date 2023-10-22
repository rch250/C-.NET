﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3a
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void Video_Load(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                this.mytextBox.Text = openFileDialog1.FileName; 
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = this.mytextBox.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = this.mytextBox.Text;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = this.mytextBox.Text;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
