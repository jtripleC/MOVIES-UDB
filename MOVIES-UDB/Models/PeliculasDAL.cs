using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MOVIES_UDB.Models
{
    public class PeliculasDAL
    {
        IDbConnection _conn = DBCommon.Conexion();
        //Metodo para agregar
        public int AgregarPelicula(PeliculasEN pEN)
        {
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("AgregarPeliculas", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@Nombre", pEN.Nombre));
            _Comand.Parameters.Add(new SqlParameter("@Descripcion", pEN.Descripcion));
            _Comand.Parameters.Add(new SqlParameter("@Imagen", pEN.Imagen));
            _Comand.Parameters.Add(new SqlParameter("@Genero", pEN.Genero));
            _Comand.Parameters.Add(new SqlParameter("@Director", pEN.Director));
            int Resultado = _Comand.ExecuteNonQuery();
            _conn.Close();
            return Resultado;
        }



        //Metodo de consulta

        public List<PeliculasEN> ConsultarPeliculas()
        {
            _conn.Open();
            SqlCommand _comand = new SqlCommand("ConsultarPeliculas", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comand.ExecuteReader();
            List<PeliculasEN> _lista = new List<PeliculasEN>();
            while (_reader.Read())
            {
                PeliculasEN pEN = new PeliculasEN();
                pEN.Id = _reader.GetInt64(0);
                pEN.Nombre = _reader.GetString(1);
                pEN.Descripcion = _reader.GetString(2);
                pEN.Imagen = _reader.GetString(3);
                pEN.Genero = _reader.GetString(4);
                pEN.Director = _reader.GetString(5);

                _lista.Add(pEN);
            }
            _conn.Close();
            return _lista;
        }

    }
}