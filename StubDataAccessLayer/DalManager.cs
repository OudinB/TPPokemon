﻿using System;
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
        public List<Tournoi> LsTournoi { get; set; }
      //  public List<Caracteristiques> LsCaractéristique { get; set; }
        public List<Utilisateur> LsUtilisateur { get; set; }

		public IList<Pokemon> getPokemonByElement(ETypeElement elem) {
			var query = from pokemon in LsPokemon
						where pokemon.TypeElement == elem
						select pokemon;
			return query.ToList();
		}

        public Pokemon getPokemonByName(string login)
        {
            var query = (from pokemon in LsPokemon
                         where pokemon.Nom == login
                         select pokemon).First();

            return (Pokemon)query;
        }
        public Pokemon getPokemonByID(int id)
        {
            var query = (from pokemon in LsPokemon
                         where pokemon.ID == id
                         select pokemon).First();

            return (Pokemon)query;
        }

        public DalManager() {
			LsPokemon = new List<Pokemon>();

            Pokemon dracofeu=new Pokemon("Dracofeu", ETypeElement.Feu, 130, 60, 30, 45, 35);
            LsPokemon.Add(dracofeu);
            Pokemon pikachu = new Pokemon("Pikachu", ETypeElement.Electrique, 100, 25, 38, 18, 40);
            LsPokemon.Add(pikachu);
            Pokemon bulbizarre= new Pokemon("Bulbizarre", ETypeElement.Plante, 90, 22, 27, 18, 20);
            LsPokemon.Add(bulbizarre);
            Pokemon leviator = new Pokemon("Leviator", ETypeElement.Eau, 150, 77, 19, 30, 38);
            LsPokemon.Add(leviator);
            Pokemon fantominus = new Pokemon("Fantominus", ETypeElement.Spectre, 80, 32, 24, 20, 18);
            LsPokemon.Add(fantominus);
            Pokemon carapuce = new Pokemon("Carapuce", ETypeElement.Eau, 90, 21, 30, 20, 19);
            LsPokemon.Add(carapuce);
            Pokemon lugia = new Pokemon("Lugia", ETypeElement.Psy, 140, 60, 30, 40, 55);
            LsPokemon.Add(lugia);
            Pokemon ho_oh = new Pokemon("Ho-oh", ETypeElement.Feu, 140, 63, 31, 31, 40);
            LsPokemon.Add(ho_oh);
            LsDresseur = new List<Dresseur>();
            LsDresseur.Add(new Dresseur("Freddy"));

			LsMatch = new List<Match>();
            LsMatch.Add(new Match(new Pokemon("Tortank", ETypeElement.Eau), new Pokemon("Raichu", ETypeElement.Electrique), EPhaseTournoi.DemiFinale));
			LsStade = new List<Stade>();
            LsStade.Add(new Stade(200, "Ligue"));
            //LsCaractéristique = new List<Caracteristiques>();
            LsMatch.Add(new Match(pikachu,leviator));

            
            LsTournoi = new List<Tournoi>();
            Tournoi tournoi1 = new Tournoi("Ligue Emeraude");
            LsTournoi.Add(tournoi1);
            tournoi1.AjouterMatch(new Match(dracofeu, fantominus));
            tournoi1.AjouterMatch(new Match(ho_oh, leviator));
            tournoi1.AjouterMatch(new Match(carapuce, bulbizarre));
            tournoi1.AjouterMatch(new Match(pikachu, lugia));
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
