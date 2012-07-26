using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormTest1
{
	public class Program
	{

		/// <summary>
		/// Main entry point
		/// </summary>
		[STAThread]
		static void Main ()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1()); 
		}
	}
}

