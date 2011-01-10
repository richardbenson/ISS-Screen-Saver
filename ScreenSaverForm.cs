using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ScreenSaver
{
	public class ScreenSaverForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private Point MouseXY;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;

		public ScreenSaverForm()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void ScreenSaverForm_Load(object sender, System.EventArgs e)
		{
			Cursor.Hide();
			TopMost = true;
		}

		private void OnMouseEvent(object sender, System.Windows.Forms.MouseEventArgs e)
		{
           if (!MouseXY.IsEmpty)
			{
				if (MouseXY != new Point(e.X, e.Y))
					Close();
				if (e.Clicks > 0)
					Close();
			}
			MouseXY = new Point(e.X, e.Y);
		}

        private void WMP1_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if (!MouseXY.IsEmpty)
            {
                if (MouseXY != new Point(e.fX, e.fY))
                    Close();
                if (e.nButton > 0)
                    Close();
            }
            MouseXY = new Point(e.fX, e.fY);
        }
        private void ScreenSaverForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
            Close();
		}

        private void WMP1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            Close();
        }

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSaverForm));
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP1
            // 
            this.WMP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(0, 0);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(292, 273);
            this.WMP1.TabIndex = 0;
            this.WMP1.UseWaitCursor = true;
            this.WMP1.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.WMP1_KeyDownEvent);
            this.WMP1.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.WMP1_MouseMoveEvent);
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.WMP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.Text = "ScreenSaver";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	}
}
