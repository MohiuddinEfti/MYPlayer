﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYPlayer
{
    public partial class BrowserPlayer : Form
    {
        public BrowserPlayer()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void BrowserPlayer_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}