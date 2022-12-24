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
    public class ServiceCitoyen : Service<Citoyen>, ICitoyenInterface
    {
        public ServiceCitoyen(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IGrouping<string,IEnumerable<Citoyen>> CitoyensVaccinees()
        {
            return (IGrouping<string, IEnumerable<Citoyen>>)GetMany(C => C.RendezVous.Count > 0).GroupBy(c => c.Adresse.Ville) ;
        }
    }
}
