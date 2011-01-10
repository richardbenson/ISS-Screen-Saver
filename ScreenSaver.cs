using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ScreenSaver
{
	public class DotNETScreenSaver
	{
        private static List<Form> Savers = new List<Form> { };
        private static Form tmpForm;
        
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
            foreach (Screen s in Screen.AllScreens)
            {
                if (s.Primary)
                {
                    tmpForm = new ScreenSaverForm();
                }
                else
                {
                    tmpForm = new Blanker();
                }
                tmpForm.Bounds = s.Bounds;
                Savers.Add(tmpForm);
                System.Windows.Forms.Application.Run(tmpForm);
            }
        }
    }
}
