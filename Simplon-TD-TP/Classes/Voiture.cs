using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplon_TD_TP.Classes
{
    /** indicateur  de visibilité  public/private/protected/internal*/
    internal class Voiture
    {
        /** Attributs :
         * Un ensemble de variables permettant de définir les caractèristique de notre objet ( variable d'instance).
         * Ils doivent être déclarés par convention au début de notre classe.
         * Tout type ( int, float, string, List<>, Voiture, Personne... )
         * norme de nomenclature : private String _model; private string _model = "Tesla";
         */
        #region "Attributs"
        private string _model;
        private string _couleur;
        private int _reservoir;
        private int _autonomie;
        #endregion

        /** Propriétés :
         * GetXXX() et SetXXX()
         * En C#, l'encapsulation est simplifiée par le principe de propriétés,
         * En regroupant le Getter, et le Setter en un élément de la classe.
         * { get => _model; set => _model = value }
         * public string Model { get => _model; set => _model = value }
         * Getter : définie un comportement à la récuperation
         * Setter : définie un comportement spécifique à la modification
         * En Java, on parle de méthode getAttribut() et setAttribut(valeur)
         * 
         * On souhaite que notre attribut model ne soit pas modifiable (pas de setter):
         *  public string Model { get => _model; }
         *  public string Model { get => "  "+_model+" "; }
         *  
         *  Une autopropriety : on donne pas d'instruction, on va cacher les propriétés des valeurs
         *  public string Model { get; set; }
         *  
         *  Le constructeur :
         *   Outil pour créer des nouvelles voitures
         *   Le constructeur défninit la manière de créer l'instance
         */
        #region "Propriétés"
        public string Model { get => _model; set => _model = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        public int Reservoir { get => _reservoir; set => _reservoir = value; }
        public int Autonomie { get => _autonomie; set => _autonomie = value<0 ? 0 : value; }
        #endregion

        #region "Constructeurs"
        public Voiture(string model, string couleur, int reservoir, int autonomie) 
        {
            _model      = model;
            _couleur    = couleur;
            _reservoir  = reservoir;
            _autonomie  = autonomie;
        }
        #endregion
    }
}
