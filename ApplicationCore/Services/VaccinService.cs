using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class VaccinService : Service<Vaccin>, IVaccinService
    {
        public VaccinService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public string ValiditeVaccin(Vaccin vaccin)
        {
            if (vaccin.DateValidite > DateTime.Now && vaccin.Quantite > 0)
            {
                return "Valide";
            }
            else return "Non Valide";
        }

    }
}
