using Academia.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Academia.Data
{
    public class CursosDB
    {
        public List<Cursos> Listar()
        {
            var listado = new List<Cursos>();
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Cursos", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Cursos tipo;
                            while (lector.Read())
                            {
                                tipo = new Cursos()
                                {
                                    Id = int.Parse(lector["Id"].ToString()),
                                    Nombre = lector["Nombre"].ToString()
                                };
                                listado.Add(tipo);
                            }
                        }
                    }
                }
            }

            return listado;
        }
    }
}
