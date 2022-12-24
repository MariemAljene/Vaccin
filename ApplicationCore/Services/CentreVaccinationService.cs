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
    public class CentreVaccinationService : Service<CentreVaccination>, ICentreService
    {
        public CentreVaccinationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public bool VerifCapacite(DateTime dateVaccination,CentreVaccination centre)
        {
            int totalCitoyen = 0; 
            foreach(Vaccin v in centre.Vaccins)
            {
                totalCitoyen += v.RendezVous.Count(r=>r.DateVaccination==dateVaccination) ;//ou .Where()
            }
           if (totalCitoyen < centre.Capacite)
            {
                return true;
            }
            else return false; 
        }
    }
}
