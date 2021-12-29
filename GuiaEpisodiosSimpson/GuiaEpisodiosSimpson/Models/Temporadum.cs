using System;
using System.Collections.Generic;

#nullable disable

namespace GuiaEpisodiosSimpson.Models
{
    public partial class Temporadum
    {
        public Temporadum()
        {
            Episodios = new HashSet<Episodio>();
        }

        public int Id { get; set; }
        public string Temporada { get; set; }
        public string FechaEstreno { get; set; }

        public virtual ICollection<Episodio> Episodios { get; set; }
    }
}
