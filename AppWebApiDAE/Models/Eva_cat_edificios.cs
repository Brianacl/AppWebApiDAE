﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace AppWebApiDAE.Models
{
    public class Eva_cat_edificios
    {
        [Key]
        [Required]
        public Int16 IdEdificio { get; set; }
        public string Alias { get; set; }
        public string DesEdificio { get; set; }
        public Int16 Prioridad { get; set; }
        public string Clave { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioReg { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }

        //public virtual ICollection<Eva_cat_espacios> Espacios { get; set; }
    }
}
