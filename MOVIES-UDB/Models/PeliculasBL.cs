using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOVIES_UDB.Models
{
    public class PeliculasBL
    {
        PeliculasDAL _dal = new PeliculasDAL();

        public int AgregarPelicula(PeliculasEN pEN)
        {
            return _dal.AgregarPelicula(pEN);
        }

        public List<PeliculasEN> ConsultarPeliculas()
        {
            return _dal.ConsultarPeliculas();
        }
    }
}