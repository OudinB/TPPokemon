using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace StubDataAccessLayer
{
	public class DalManager {
		public List<Pokemon> LsPokemon { get; set; }
        public List<Dresseur> LsDresseur { get; set; }
		public List<Match> LsMatch { get; set; }
		public List<Stade> LsStade { get; set; }
		public List<Caracteristiques> LsCaractéristique { get; set; }
        public List<Utilisateur> LsUtilisateur { get; set; }

		public IList<Pokemon> getPokemonByElement(ETypeElement elem) {
			var query = from pokemon in LsPokemon
						where pokemon.TypeElement == elem
						select pokemon;
			return query.ToList();
		}

		public DalManager() {
			LsPokemon = new List<Pokemon>();
            LsPokemon.Add(new Pokemon("Pika", ETypeElement.Electrique)); //ajoute pokemon temporaire pour test
            LsPokemon.Add(new Pokemon("Salameche", ETypeElement.Feu));
            LsPokemon.Add(new Pokemon("Carapuce", ETypeElement.Eau));
            LsDresseur = new List<Dresseur>();
            LsDresseur.Add(new Dresseur("Freddy"));
			LsMatch = new List<Match>();
            LsMatch.Add(new Match(new Pokemon("Pika", ETypeElement.Electrique), new Pokemon("raichu", ETypeElement.Electrique), EPhaseTournoi.DemiFinale));
			LsStade = new List<Stade>();
            LsStade.Add(new Stade(200, "Ligue"));
            LsCaractéristique = new List<Caracteristiques>();
		}

        public Utilisateur GetUtilisateurByLogin(String plogin)
        {
            var query = from user in LsUtilisateur
                        where user.getLogin() == plogin
                        select user;
            return (Utilisateur)query;
        }
    }
}
