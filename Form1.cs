using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRibbon_4X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonAboutButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new frmAbout())
            {
                dialog.ShowDialog(this);
            }
        }
    }
}
