namespace FormsNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarFormulario(object sender, EventArgs e)
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
    }
}