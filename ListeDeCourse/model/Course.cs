﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
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
    }
}
