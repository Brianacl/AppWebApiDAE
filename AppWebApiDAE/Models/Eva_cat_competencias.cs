using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppWebApiDAE.Models
{
    public class Eva_cat_competencias
    {
        [Key]
        [Required]
        public int IdCompetencia { get; set; }
        public Int16 IdTipoCompetencia { get; set; }
        public string DesCompetencia { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }

        public ICollection<Eva_cat_conocimientos> Conocimientos { get; set; }
    }
}
