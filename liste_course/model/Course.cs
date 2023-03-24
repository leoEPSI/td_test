﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.model
{
    internal class Course
    {
        private int quantite;
        private Produit produit;
    
        public Course(int quantite, Produit produit)
        {
            this.quantite = quantite;
            this.produit = produit;
        }

        public int getQuantite()
        {
            return quantite;
        }

        public Produit getProduit()
        {
            return produit;
        }

        public void setQuantite(int quantite)
        {
            this.quantite = quantite;
        }

        public void setProduit(Produit produit)
        { 
            this.produit = produit;
        }
    }
}
