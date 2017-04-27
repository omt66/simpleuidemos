using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            // Here we need to create and show the 2nd WinForm
            var secondForm = new SecondForm();
            secondForm.ShowDialog();
        }
    }
}
