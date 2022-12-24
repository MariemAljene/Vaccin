using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICentreService:IService<CentreVaccination>
    {
        bool VerifCapacite(DateTime dateVaccination, CentreVaccination centre);
    }
}
