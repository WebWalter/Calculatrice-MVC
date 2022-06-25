using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Calculatrice_MVC.Models
{
    public class Calculatrice
    {
        [Display(Name = "Nombre 1")]
        public double a { get; set; }
        [Display(Name = "Nombre 2")]
        public double b { get; set; }
        [Display(Name = "Resultat")]
        public double result { get; set; }
    }
}