using Academia.AppWin;
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

namespace NOTAS_ALUMNOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarForm(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            dgvDatos.Rows.Clear();
            var listado = NotasBL.Listar();
            foreach (var notas in listado)
            {
                dgvDatos.Rows.Add(notas.IdAulmno, notas.IdCurso, notas.Eva1, notas.Parcial, notas.Eva2, notas.Final);
            }
        }

        private void NuevaNota(object sender, EventArgs e)
        {
            var nuevaNota = new Notas();
            var frm = new FrmNotas(nuevaNota);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var resultado = NotasBL.Insertar(nuevaNota);
                if (resultado)
                {
                    MessageBox.Show("Datos registrados", "Sistemas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar los datos", "Sistemas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
