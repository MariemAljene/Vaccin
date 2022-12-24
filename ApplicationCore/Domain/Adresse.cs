using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    [Owned]
    //[ComplexType]
    public class Adresse
    {
       
        public int CodePostal { get; set; }
        public int Rue { get; set; }
        public string Ville { get; set; }
    }
}
