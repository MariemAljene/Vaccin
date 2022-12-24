using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{ 
    public class Citoyen
    {

        public virtual Adresse Adresse { get; set; }
        public int Age { get; set; }
        [Key]
        public string CIN { get; set; }
        public string Nom { get; set; }
        [Required]
        public int NumeroEvax { get; set; }
        public string Prenom { get; set; }
        public int Telephone { get; set; } 
        public virtual IList<RendezVous>RendezVous { get; set; }

    } 
}
