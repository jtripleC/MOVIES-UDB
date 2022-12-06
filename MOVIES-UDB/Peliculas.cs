namespace MOVIES_UDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Peliculas
    {
        public long Id { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        [StringLength(100)]
        public string Genero { get; set; }

        [StringLength(100)]
        public string Director { get; set; }
    }
}
