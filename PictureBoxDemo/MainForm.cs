using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxDemo
{
    public partial class MainForm : Form
    {
        private int imageNum = 0;
        private int nofImages = 5;

        private AppSettings settings = AppSettings.Instance;

        public MainForm()
        {
            InitializeComponent();

            settings.AddListener(() => {
                // Now something happend in the settings so act accordingly!
                slideshowTimer.Enabled = settings.EnableAutoSlideshow;
                slideshowTimer.Interval = settings.TimerInterval;
            });
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            imageNum++;
            LoadImage();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            imageNum--;
            LoadImage();
        }

        private void LoadImage()
        {
            if (imageNum >= nofImages)
            {
                imageNum = 0;
            }
            else if (imageNum < 0)
            {
                imageNum = nofImages - 1;
            }

            var imageName = string.Format("img{0}", imageNum);

            imagePictureBox.Image = 
                (Image)Properties.Resources.ResourceManager.GetObject(imageName);
        }

        private void slideshowTimer_Tick(object sender, EventArgs e)
        {
            imageNum++;
            LoadImage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Now show the settings form!
            var form = new SettingsForm();
            form.ShowDialog();
        }
    }
}
