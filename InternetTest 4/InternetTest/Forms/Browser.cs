using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetTest.Classes;

namespace InternetTest.Forms
{
    public partial class Browser : Form
    {
        string url;
        public Browser(string site)
        {
            InitializeComponent();
            url = site;
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            int x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Location = new Point(x, y);
            Icon = new Branches().IconBranch(); // Met l'icône en foncion de la branche
            ChangeTheme();
            gunaPictureBox1.Image = new Branches().ImageBranch(); // Met l'image en fonction de la branche
            webBrowser1.Url = new Uri(url); // Charger la page Internet demandée
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ChangeTheme()
        {
            if (Theme.IsDark()) // Mettre le thème sombre
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaAdvenceTileButton1.Image = Properties.Resources.icons8_delete_32px;
                gunaAdvenceTileButton2.Image = Properties.Resources.icons8_subtract_100px;
                gunaAdvenceTileButton3.Image = Properties.Resources.icons8_enlarge_100px;
            }
            else // Mettre le thème clair
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaAdvenceTileButton1.Image = Properties.Resources.icons8_delete_100px_1;
                gunaAdvenceTileButton2.Image = Properties.Resources.icons8_subtract_100px_1;
                gunaAdvenceTileButton3.Image = Properties.Resources.icons8_enlarge_100px_1;
            }
        }
    }
}
