using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebApiDAE.Models
{
    public class Eva_cat_tipo_competencia
    {
        [Key]
        [Required]
        public Int16 IdTipoCompetencia { get; set; }
        public string DesTipoCompetencia { get; set; }
        public DateTime FechaReg { get; set; }
        public string UsuarioReg { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioMod { get; set; }
        public string Activo { get; set; }
        public string Borrado { get; set; }

        public ICollection<Eva_cat_competencias> Competencias {get; set;}
    }
}
