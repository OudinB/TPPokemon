using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
	public class Match : EntityObject {
		public int IdPokemonVainqueur { get; }
        public EPhaseTournoi PhaseTournoi { get; }
        public Pokemon Pokemon1 { get; }
        public Pokemon Pokemon2 { get; }
        public Stade Arene { get; }

        public Match(ref Pokemon ppokemon1, ref Pokemon ppokemon2, EPhaseTournoi pphase = EPhaseTournoi.HuitiemeFinale) {
			PhaseTournoi = pphase;
			Pokemon1 = ppokemon1;
			Pokemon2 = ppokemon2;
		}
		public Match(Pokemon ppokemon1, Pokemon ppokemon2, EPhaseTournoi pphase = EPhaseTournoi.HuitiemeFinale) {
			PhaseTournoi = pphase;
			Pokemon1 = ppokemon1;
			Pokemon2 = ppokemon2;
		}

		public override String ToString() {
			return ("Match " + ID + " : " + Pokemon1.Nom + " VS " + Pokemon2.Nom );
		}
	}
}
