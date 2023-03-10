using Academia.Data;
using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Negocio
{
    public static class CursosBL
    {
        public static List<Cursos> Listar()
        {
            var cursosBD = new CursosDB();
            return cursosBD.Listar();
        }
    }
}
