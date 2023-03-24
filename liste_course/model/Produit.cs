using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.model
{
    internal class Produit
    {
        //attribut
        private int id;
        private String nom;
        private int prix;

        // constructeur
        public Produit() { }

        public Produit(int id, String nom, int prix)
        {
            this.id = id;
            this.nom = nom;
            this.prix = prix;
        }

        public int getId()
        {
            return this.id;
        }
        public string getNom()
        {
            return this.nom;
        }
        public int getPrix()
        {
            return this.prix;
        }
    }
}
