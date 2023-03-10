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
            cboAlumno.DisplayMember = "Nombres";
            cboAlumno.DisplayMember = "Codigo";
            cboAlumno.ValueMember = "ID";

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
    }
}
