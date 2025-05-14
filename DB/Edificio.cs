using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Edificio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EdificioID { get; set; }

        public string? EdificioName { get; set; }
        [ForeignKey("PlanetaID")]
        public int PlanetaID { get; set; }

        public virtual Planeta Planeta { get; set; }
    }
}
