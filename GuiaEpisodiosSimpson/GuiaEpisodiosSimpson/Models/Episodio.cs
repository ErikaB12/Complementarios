using System;
using System.Collections.Generic;

#nullable disable

namespace GuiaEpisodiosSimpson.Models
{
    public partial class Episodio
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdTemporada { get; set; }

        public virtual Temporadum IdTemporadaNavigation { get; set; }
    }
}
