
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awok
{
	


	class backend
	{



		// NName: Bekommt neuen Nuternamen 
		// Fügt ihn einer Liste hinzu
		// B : Befehl was zu machen ist 
		// A : Add | D : Delete 
		// S : Stats 
		public static void BSpeicher(string NName,string B)
		{

			string b = B;
			// Benutzernamensliste
			List<string> name = new List<string>();

			// Demo User
			name.Add("PoWeR");

			// Add
			if(b == "A")
			{
				name.Add(NName);
				System.Windows.Forms.MessageBox.Show(NName +" hinzugefügt","Backend");

			}
			// Delete letzten Benutzernamen
			if(b == "D")
			{
				string LBNamen;
			 LBNamen =	name.Last() ;
				name.Remove(LBNamen);
			}
			// Binde Liste mit GUI liste
			Benutzer ALB = new Benutzer();

	
			
			

			
			// Stats
			if (b == "S")
			{
			int ZBNamen = name.Count;
			int KBNamen = name.Capacity;
			string RLBNamen = name.Last();
			}


		}



		static void VokSpeicher(string karte1,string karte2)
		{

		}

	}
}
