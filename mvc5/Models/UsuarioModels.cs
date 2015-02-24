﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MVC5.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre_Usuario { get; set; }
        [Required]
        [StringLength(50)]
        public string Contrasenna { get; set; }
    }

    public class dbSistemaNutricion : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}