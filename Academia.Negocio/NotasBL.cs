using Academia.Data;
using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Negocio
{
    public static class NotasBL
    {
        public static List<Notas> Listar()
        {
            var notasDB = new NotasDB();
            return notasDB.Listar();
        }

        public static bool Insertar(Notas notas)
        {
            var clienteDB = new NotasDB();
            return clienteDB.Insertar(notas) > 0;
        }
    }
}
