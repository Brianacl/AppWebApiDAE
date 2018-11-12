using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebApiDAE.Models
{
    public class Eva_cat_conocimientos
    {
        [Key]
        [Required]
        public int IdConocimiento { get; set; }
        public int IdCompetencia { get; set; }
        public string DesConocimiento { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }
    }
}
