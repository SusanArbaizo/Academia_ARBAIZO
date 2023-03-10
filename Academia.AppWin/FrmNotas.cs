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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Academia.AppWin
{
    public partial class FrmNotas : Form
    {

        Notas _notas;
        public FrmNotas(Notas notas)
        {
            InitializeComponent();
            this._notas = notas;
        }

        private void nuevoRegistroNotas(object sender, EventArgs e)
        {

        }

        private void cargarFormulario(object sender, EventArgs e)
        {
            cargarDatos();
        }
        void cargarDatos()
        {
            var listadoAlumno = AlumnosBL.Listar();
            cboAlumno.DataSource = listadoAlumno;
            cboAlumno.DisplayMember = "NombreCompleto";
            cboAlumno.ValueMember = "ID";

            //cboAlumno.ValueMember = "ID";

            var listadoCurso = CursosBL.Listar();
            cboCurso.DataSource = listadoCurso;
            cboCurso.DisplayMember = "Nombre";
            cboCurso.ValueMember = "ID";
        }
        void asignarDatos()
        {
            this._notas.IdAulmno = int.Parse(cboAlumno.SelectedValue.ToString());
            this._notas.IdCurso = int.Parse(cboCurso.SelectedValue.ToString());
            this._notas.Eva1 = decimal.Parse(txteva1.Text);
            this._notas.Parcial= decimal.Parse(txtparcial.Text);
            this._notas.Eva2 = decimal.Parse(txteva2.Text)  ;
            this._notas.Final = decimal.Parse(txtfinal.Text)    ;
            
        }


        private void AceptarDatos(object sender, EventArgs e)
        {
            asignarDatos();
            this.DialogResult = DialogResult.OK;
        }

        private void txteva1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txteva1.Text, out decimal valor) && valor >= 0 && valor <= 20)
            {
                // El valor es válido, no se hace nada
            }
            else
            {
                // El valor no es válido, se muestra un mensaje de error y se borra el valor del TextBox
                MessageBox.Show("El valor debe estar entre 0 y 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txteva1.Text = string.Empty;
                txteva1.Focus();
            }
        }

        private void txteva2_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txteva2.Text, out decimal valor) && valor >= 0 && valor <= 20)
            {
                // El valor es válido, no se hace nada
            }
            else
            {
                // El valor no es válido, se muestra un mensaje de error y se borra el valor del TextBox
                MessageBox.Show("El valor debe estar entre 0 y 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txteva2.Text = string.Empty;
                txteva2.Focus();
            }
        }

        private void txtparcial_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtparcial.Text, out decimal valor) && valor >= 0 && valor <= 20)
            {
                // El valor es válido, no se hace nada
            }
            else
            {
                // El valor no es válido, se muestra un mensaje de error y se borra el valor del TextBox
                MessageBox.Show("El valor debe estar entre 0 y 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtparcial.Text = string.Empty;
                txtparcial.Focus();
            }
        }

        private void txtfinal_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtfinal.Text, out decimal valor) && valor >= 0 && valor <= 20)
            {
                // El valor es válido
            }
            else
            {
                // El valor no es válido, se muestra un mensaje de error y se borra el valor del TextBox
                MessageBox.Show("El valor debe estar entre 0 y 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfinal.Text = string.Empty;
                txtfinal.Focus();
            }
        }
    }
}
