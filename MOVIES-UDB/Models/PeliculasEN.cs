using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOVIES_UDB.Models
{
    public class PeliculasEN
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }

    }
}