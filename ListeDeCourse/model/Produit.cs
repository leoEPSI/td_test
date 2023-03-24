using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class Produit
    {
        //attribut
        private int id { get; set; }
        private String nom { get; set; }
        private int prix { get; set; }

        // constructeur
        public Produit() { }

        public Produit(int id, String nom, int prix)
        {
            this.id = id;
            this.nom = nom;
            this.prix = prix;
        }


    }
}
