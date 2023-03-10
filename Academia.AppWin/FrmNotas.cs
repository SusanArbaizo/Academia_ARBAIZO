using Academia.Data;
using Academia.Entidades;
using Academia.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.AppWin
{
    public partial class FrmNotas : Form
    {

        Notas _notas;
        public FrmNotas()
        {
            InitializeComponent();
            this._notas = NotasDB;
        }

        private void nuevoRegistroNotas(object sender, EventArgs e)
        {

        }

        private void cargarFormulario(object sender, EventArgs e)
        {
            
        }
        

    }
}
