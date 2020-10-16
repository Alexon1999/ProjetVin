using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            LesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            return lesCaves[unNomDeCave].Count;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            // A vous de jouer
            int nbRouges = 0;

            foreach(Bouteille unBouteulle in lesCaves[unNomDeCave])
            {
                if (unBouteulle.LeVin.LaCouleur.NomCouleur == "Rouge")
                {
                    nbRouges++;
                }
            }

                return nbRouges;

        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            double valeur = 0;

            lesCaves[unNomDeCave].ForEach(bouteuille =>
            {
                valeur += bouteuille.QuantiteBouteille * bouteuille.LeVin.PrixDuVin;
            });

            return valeur;

        }
    }
}
