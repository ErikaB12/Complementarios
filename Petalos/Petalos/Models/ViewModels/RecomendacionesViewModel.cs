using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petalos.Models.ViewModels
{
    public class RecomendacionesViewModel
    {
        public Datosflores Datosflores { get; set; }
        public IEnumerable<Datosflores> Recomendacion { get; set; }
    }
}
