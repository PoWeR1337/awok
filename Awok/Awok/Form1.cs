using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awok
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.MenuText.Text = "Eingabe";
			this.eingabe1.Visible = true;
		}

		private void X_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Mini_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void BenutzerB_Click(object sender, EventArgs e)
		{
			this.MenuText.Text = "Benutzer";
			this.benutzer1.Visible = true;
		}

		private void Inhalt_Paint(object sender, PaintEventArgs e)
		{
		
		}

		private void MenuText_Click(object sender, EventArgs e)
		{

		}

		private void AbfrageB_Click(object sender, EventArgs e)
		{
			this.MenuText.Text = "Abfrage";
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			this.MenuText.Text = "Optionenr";
		}

		private void PanelLinks_Paint(object sender, PaintEventArgs e)
		{

		}

		private void PanelLogo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void PanelOben_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Benutzer1_Load(object sender, EventArgs e)
		{

		}

		private void Eingabe1_Load(object sender, EventArgs e)
		{

		}
	}
}
