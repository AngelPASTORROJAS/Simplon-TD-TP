/** Objet : Un objet est l'instance d'une classe.
 * Càd un élément qui possède les caracteristiques et les comportements définis par la classe.
 * 
 *  Une Classe : un modèle qui décrit les caractéristique et les comportements communs d'un ensemble d'objets
 * Ex: Voiture
 * 
 *  Méthode : fonction associéé à une classe ou à un objet qui définit un comportement spécidique
 * Ex: Accelerer()
 * 
 * Propriété : attribut associé à un objet ou une classe qui définit une caractéristique spécifique.
 * Ex: Couleur
 * 
 * Une classe est un type de donnée
 *  Génère des objets
 *  N'occupe pas d'espace en mémoire
 *  Ne peut pas être manipulé (sauf static)
 * 
 * Un objet est une intance de classe
 *  Donne vie à une classe
 *  Occupe de l'espace en mémoire
 *  Peut être manipulé
 *  
 *  La class program est une classe particulièer car elle contient la méthode "Main()"
 *  Le point d'entrée de l'application
 *  
 *  Les classes s'écrivent en PascalCase : MaNouvelleClasse
 *  
 *   Encapsulation :
 *  L'encapsulation est un moyen de restreindre l'accès direct à certains composant de l'objet,
 *  de sorte que l'utilisateur ne peut accèder aux valeurs d'état de toutes les variables
 *  d'un objet particulier.
 *  L'encapsulation peut être utilisée pour masquer à la fois les membres des données et 
 *  les fonctions ou méthodes associés à une classe ou à un objet instancié
 */
using Simplon_TD_TP.Classes;

/// Voiture maVoiture = new Voiture("Clio", "Grise", 70, 800);
/// maVoiture.ToString();

Chaise chaise1 = new Chaise();
chaise1.Couleur = "Blanche";
chaise1.Materiaux = "Bois";
chaise1.NbPieds = 4;

Chaise chaise2 = new Chaise(2,"Métal","Noire");
Chaise chaise3 = new Chaise(6,"Plastique","Bleue");

Console.WriteLine(chaise1.ToString());
Console.WriteLine(chaise2.ToString());
Console.WriteLine(chaise3.ToString());


