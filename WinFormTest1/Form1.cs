using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace WinFormTest1
{
	public class Form1 : Form
	{ 
		private Button b;
		private int i = 0;

		public Form1 ()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.Font = new Font("Osaka",20);
			this.ClientSize = new Size (400, 60);
			this.Text = "Hello";
			// button b
			this.b = new Button ();
			this.b.Text = "こんにちは、世界！";
			this.b.Dock = DockStyle.Fill;
			this.b.Click += new EventHandler (Button_Clicked);
			this.Controls.Add (this.b);
		}

		///////////////////////////////////////////////////////////////////////////
		// Button_Clicked
		private void Button_Clicked (object sender, EventArgs e)
		{
		  	System.Console.Write ("ボタンがクリックされました。\n");
			this.b.Text += i++;
		}
	}
}

