using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** -- Chaise sujet ---
    Créer une classe Chaise possédant comme variables d’instance :
        - le nombre de pieds, 
        - le matériaux
        - la couleur de l’objet

    Afficher ses informations en surchargeant une méthode de la classe Object

    La classe Chaise pourra être instanciée avec ou sans paramètres (Constructeur par défaut)

    Afficher toutes les chaises (Possibilité de simplifier avec une méthode ToString)
 */
namespace Simplon_TD_TP.Classes
{
    internal class Chaise
    {
        #region "Attributs"
        private int _nbPieds;
        private string _materiaux;
        private string _couleur;
        #endregion

        #region "Propriétés"
        public int NbPieds { get => _nbPieds; set => _nbPieds = value>0?value:0; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        #endregion

        #region "Constructeurs"
        public Chaise(int nbPieds, string materiaux, string couleur)
        {
            #region Contrôle de propriétés
            Couleur = couleur;
            Materiaux = materiaux;
            NbPieds = nbPieds;
            #endregion
        }

        public Chaise() { }
        #endregion

        /** La surcharge est une possibilité offerte par certains langages de programmation qui permet 
         * de choisir entre différentes implémentations d'une même fonction ou méthode selon le nombre 
         * et le type des arguments fournis
         * 
         * Surcharge statique : implémentation faite à la compilation en
         *  fonction du nombre d'arguments et de leur type statique déclaré
         * 
         * Surcharge dynamique : l'implémentation faite à l'exécution en
         *  fonction du type dynamique des arguments
         */
        #region "Méthodes"
        public override string ToString()
        {
            return $"Je suis une Chaise, avec {NbPieds} pieds en {Materiaux} et de couleur {Couleur}";
        }
        #endregion
    }
}
