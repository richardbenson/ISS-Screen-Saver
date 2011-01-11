using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class Blanker : Form
    {
        public Blanker(int screen)
        {
            InitializeComponent();
            //this.Left = Screen.AllScreens[screen].Bounds.Width;
            //this.Top = Screen.AllScreens[screen].Bounds.Height;
            //this.Location = Screen.AllScreens[screen].Bounds.Location;
            this.Bounds = Screen.AllScreens[screen].Bounds;
        }
    }
}
