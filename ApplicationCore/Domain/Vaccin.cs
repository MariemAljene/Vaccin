using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{ 
    
    
    public enum TypeVaccin
    {
        Pfizer,Moderna,Jhonson
    }
    public class Vaccin
    {
        [DataType(DataType.DateTime)]
        public DateTime DateValidite { get; set; }
        public string Fournisseur { get; set; }
        public int Quantite { get; set; }
        public TypeVaccin TypeVaccin { get; set; }
        public int VaccinId { get; set; }
        [ForeignKey("CentreVaccination")]
        public int CentreVaccinationFK { get; set; }
        [NotMapped]
        public string Validite { get; set; } 

        public virtual CentreVaccination CentreVaccination { get; set; }
        public virtual IList<RendezVous> RendezVous { get; set; }


    }
}
