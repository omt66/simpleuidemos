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
    public partial class SettingsForm : Form
    {
        AppSettings settings = AppSettings.Instance;
        

        public SettingsForm()
        {
            InitializeComponent();

            // Get the defaults from the settings and update the UI accordingly!
            tbTimerInterval.Value = settings.TimerInterval;
            lblTimerInterval.Text = settings.TimerInterval + " ms";
            cbAutoSlideshow.Checked = settings.EnableAutoSlideshow;
        }

        private void tbTimerInterval_Scroll(object sender, EventArgs e)
        {
            lblTimerInterval.Text = tbTimerInterval.Value + " ms";
            settings.TimerInterval = tbTimerInterval.Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // I need to be able to say to the main form that new data is available 
            // for it to use...
            // ?

            settings.NotifyListeners();

            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            settings.EnableAutoSlideshow = cbAutoSlideshow.Checked;
        }
    }
}
