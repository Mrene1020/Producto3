using System;
using System.Collections.Generic;


namespace Backend.Models
{

    using System.ComponentModel.DataAnnotations;
    public class Producto
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [Display(Name ="Nombre del Producto")]

        public string Nombre { get; set; }

        public double Precio { get; set; }
    }
}