using ExamenPrimerParcial.Datos;
using ExamenPrimerParcial.Entidades;

namespace ExamenPrimerParcial
{
    public partial class Form1 : Form
    {
        RegistroPacientes registro = new RegistroPacientes();
        public Form1()
        {
            double[] estadisticas = registro.Estadisticas();

            InitializeComponent();
            panelAgregar.Visible = false;
            panelBuscar.Visible = false;
            panelEliminar.Visible = false;
            rbNombre.Checked = false;
            rbDiagnostico.Checked = false;
            rbTodos.Checked = false;
            nombreTb.Visible = false;
            diagnosticoTb.Visible = false;




        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            panelAgregar.Visible = true;
            panelBuscar.Visible = false;
            panelEliminar.Visible = false;

        }

        private void btnAgregrar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.ToLower();


            if (int.TryParse(tbEdad.Text, out int edad))
            {

                string numTel = tbNumTel.Text;
                string diagnostico = tbDiagnostico.Text.Trim();

                Paciente paciente = new Paciente(nombre, edad, numTel, diagnostico);

                registro.Add(paciente);
                registro.LimpiarTextoBox(tbNombre, tbEdad, tbNumTel, tbDiagnostico);

            }
            else
            {
                MessageBox.Show("La edad ingresada no es válida.");

            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            panelBuscar.Visible = true;
            panelAgregar.Visible = false;
            panelEliminar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (rbNombre.Checked)
            {
                listBox1.Items.Clear();
                string nombre = nombreTb.Text.ToLower();
                Paciente paciente = registro.SearchPaciente(nombre);
                paciente.ShowPacientes(listBox1, paciente);
            }
            else if (rbDiagnostico.Checked)
            {
                listBox1.Items.Clear();
                string diagnostico = diagnosticoTb.Text.Trim();
                Paciente paciente = registro.SearchPaciente(diagnostico);
                paciente.ShowPacientes(listBox1, paciente);
            }
            else if (rbTodos.Checked)
            {
                nombreTb.Text = "";
                diagnosticoTb.Text = "";
                listBox1.Items.Clear();
                registro.MostrarPacientes(listBox1);
            }





        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            nombreTb.Visible = true;
            diagnosticoTb.Visible = false;

        }

        private void rbDiagnostico_CheckedChanged(object sender, EventArgs e)
        {
            diagnosticoTb.Visible = true;
            nombreTb.Visible = false;
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            panelEliminar.Visible = true;
            panelBuscar.Visible = false;
            panelAgregar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = tbEliminar.Text.Trim().ToLower();

            registro.Delete(nombre);
            tbEliminar.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadicticas_Click(object sender, EventArgs e)
        {

            label9.Text = "";
            label8.Text = "";
            double[] estadisticas = registro.Estadisticas();

            label9.Text = estadisticas[0].ToString();
            label8.Text = estadisticas[1].ToString();

        }
    }
}