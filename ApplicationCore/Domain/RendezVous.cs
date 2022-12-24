using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class RendezVous
    {
        public string CodeInfermiere { get; set; }
        public DateTime DateVaccination { get; set; }
        public int NbDoses { get; set; }
        [ForeignKey("Citoyen")]
        public string CitoyenFK { get; set; }
        [ForeignKey("Vaccin")]
        public int VaccinFK { get; set; }
        public virtual Citoyen Citoyen { get; set; }
        public virtual Vaccin Vaccin { get; set; }

    }
}
