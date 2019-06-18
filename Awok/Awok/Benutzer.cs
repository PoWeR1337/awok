using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Awok;

namespace Awok
{
	public partial class Benutzer : UserControl
	{
		public Benutzer()
		{
			InitializeComponent();
		}

		private void Benutzer_Load(object sender, EventArgs e)
		{

		}

		private void BName_TextChanged(object sender, EventArgs e)
		{



		
		}

		private void Eingabe_Click(object sender, EventArgs e)
		{

			string TBNamen = "",B="A";

			// Wenn die Textbox nicht leer ist
			if(BName.Text.Length == 0)
			{
				System.Windows.Forms.MessageBox.Show("Gebe einen Nutzernamen ein");
			}

			else
			{
			TBNamen = BName.Text ;
			// Addet von der Textbox zur Liste
			NamenList.Items.Add(this.BName.Text);
			// Gibt dem backend den Namen und den befehl Add
			backend.BSpeicher(TBNamen, B);
			BName.Focus();
			BName.Clear();
			}

		}


		private void RemoveLNL_Click_1(object sender, EventArgs e)
		{

			// Löscht den angeklickten Namen nach klick des Buttons
			if (this.NamenList.SelectedIndex >= 0)
			{
				this.NamenList.Items.RemoveAt(this.NamenList.SelectedIndex);
			}
		}
	}
}
