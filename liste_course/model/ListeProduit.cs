using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.model
{
    internal interface ListeProduit
    {
        void AfficherListeProduit();
        bool AjouterCourse(int quantite, Produit produit);
        bool SupprimerProduit(Produit produit);
    }
}
