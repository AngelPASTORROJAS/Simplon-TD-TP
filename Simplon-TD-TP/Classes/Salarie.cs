using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplon_TD_TP.Classes
{
    internal class Salarie
    {
        #region "Attributs de la classe Global"
        private static int nbSalariee = 0;
        private static decimal salaireTotal = 0;
        #endregion

        #region "Attributs"
        private string _matricule = Guid.NewGuid().ToString();
        private string _service;
        private string _categorie;
        private string _nom;
        private decimal _salaire;
        #endregion

        #region "Propriétés"
        public string Matricule { get => _matricule; }
        public string Service { get => _service; set => _service = value; }
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public decimal Salaire { get => _salaire; set {
                if (_salaire>0)
                {
                    salaireTotal -= _salaire;
                }
                _salaire = value<0?0:value;
                salaireTotal += value;
            } }
        #endregion

        #region "Constructeurs"
        public Salarie(string service, string categorie, string nom, decimal salaire)
        {
            #region Contrôle de propriétés
            Service = service;
            Categorie = categorie;
            Nom = nom;
            Salaire = salaire;
            nbSalariee += 1;
            #endregion
        }
        #endregion

        #region "Méthode(s)"
        public string AfficherSalaire()
        {
            return $"Le salaire de {Nom} est de {Salaire} euros";
        }

        public string AfficherTotalSalarie()
        {
            return $"Le montant total des salaries des {nbSalariee} employés est de {salaireTotal}";
        }

        public string AfficheNombreSalairies()
        {
            return $"Il y a {nbSalariee} salariés.";
        }

        public void ResetNbSalariee()
        {
            nbSalariee = 0;
        }
        #endregion
    }
}
