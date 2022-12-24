using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class CentreVaccination
    {
        public int Capacite { get; set; }
        public int CentreVaccinationId { get; set; }
        public int NbChaise { get; set; }
        public int NumTelephone { get; set; }
        public string ResponsableCentre { get; set; }
        public int MyProperty { get; set; }
        public virtual IList<Vaccin> Vaccins { get; set; }

    }
}
