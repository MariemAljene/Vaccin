using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IVaccinService :IService<Vaccin>
    {
        public string ValiditeVaccin(Vaccin vaccin);

    }
}
