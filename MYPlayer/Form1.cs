using System;
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
    public partial class MyPlayer : Form
    {
        public MyPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abc;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string img = ofd.FileName;
                    if (img != "")
                    {
                       abc = img;
                    }
                    else
                    {
                        abc = string.Empty;
                    }
                    
                    axWindowsMediaPlayer1.URL = img;
                    


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BrowserPlayer bp = new BrowserPlayer();
            bp.Show();
            
        }
    }
}
