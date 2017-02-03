using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
	class Tournoi : EntityObject {
		private Match[] Matchs;
		private String Nom;

		public Tournoi(String pnom) {
			Nom = pnom;
		}
	}
}
