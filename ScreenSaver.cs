using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace ScreenSaver
{
	public class DotNETScreenSaver
	{
        private static List<Form> Savers = new List<Form> { };
        //private static Form tmpForm;
        
        [STAThread]
		static void Main(string[] args) 
		{
			if (args.Length > 0)
			{
				if (args[0].ToLower().Trim().Substring(0,2) == "/c")
				{
					MessageBox.Show("This Screen Saver has no options you can set.", ".NET Screen Saver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (args[0].ToLower() == "/s")
				{
					//for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++) 
					//	System.Windows.Forms.Application.Run(new ScreenSaverForm(i));
                    Launch();
				}
			}
			else
			{
				//for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++) 
				//	System.Windows.Forms.Application.Run(new ScreenSaverForm(i));
                Launch();
			}
		}

        static void Launch()
        {
            int primaryScreen = 0;
            for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++)
            {
                if (Screen.AllScreens[i].Primary) {
                    primaryScreen = i;
                } else {
                    new Blanker(i).Show();
                }
            }
            //MessageBox.Show("waiting");
            System.Windows.Forms.Application.Run(new ScreenSaverForm(primaryScreen));
        }
    }
}
