using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Academia.Data
{
    public class NotasDB
    {
        public List<Notas> Listar()
        {
            var listado = new List<Notas>();

            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Notas", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Notas notas;
                            while (lector.Read())
                            {
                                // CREAR UN NUEVO OBJETO 
                                notas = new Notas();
                                notas.IdAulmno = (int)lector["IdAulmno"];
                                notas.IdCurso = (int)lector["IdCurso"];
                                notas.Eva1 = (decimal)lector["Eva1"];
                                notas.Parcial = (decimal)lector["Parcial"];
                                notas.Eva2 = (decimal)lector["Eva2"];
                                notas.Final = (decimal)lector["Final"];


                                // AGREGAR AL LISTADO
                                listado.Add(notas);
                            }
                        }
                    }
                }
            }
            return listado;
        }
        public int Insertar(Notas notas)
        {
            int filas = 0;
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                var query = "INSERT INTO [dbo].[Notas] " +
                    "([IdAulmno],[IdCurso],[Eva1],[Parcial],[Eva2]," +
                    "[Final])" +
                    "VALUES(@IdAulmno,@IdCurso,@Eva1,@Parcial,@Eva2," +
                    "@Final)";
                using (var comando = new SqlCommand(query, conexion))
                {


                    comando.Parameters.AddWithValue("@IdAulmno", notas.IdAulmno);
                    comando.Parameters.AddWithValue("@IdCurso", notas.IdCurso);
                    comando.Parameters.AddWithValue("@Eva1", notas.Eva1);
                    comando.Parameters.AddWithValue("@Parcial", notas.Parcial);
                    comando.Parameters.AddWithValue("@Eva2", notas.Eva2);
                    comando.Parameters.AddWithValue("@Final", notas.Final);
                   
                    filas = comando.ExecuteNonQuery();
                }
            }
            return filas;
        }
    }
}
