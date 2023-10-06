using ExamenPrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial.Datos
{
    public class RegistroPacientes
    {

        private Paciente[] _pacientes;
        private int _indice = 0;
        

        public RegistroPacientes()
        {
            _pacientes = new Paciente[10];
        }



        public void Add(Paciente paciente)
        {
            if (_indice >= _pacientes.Length)
            {
                Array.Resize(ref _pacientes, _pacientes.Length + 1);
            }

            _pacientes[_indice] = paciente;
            _indice++;

            MessageBox.Show("Se ha agregado correctamente el paciente","Agregar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Delete( string nombre)
        {
            if (_indice <= 0)
            {
                MessageBox.Show("No hay pacientes registrados", "Advertencia", MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Warning);
                return;
            }
              


            _pacientes = _pacientes.Where(p => p != null && p.nombre != nombre).ToArray();
            _indice--;
            MessageBox.Show("Se ha eliminado correctamente el paciente","Eliminar",MessageBoxButtons.OK,
                MessageBoxIcon.Information);


        }



        public Paciente SearchPaciente(string ValorBusqueda, int index = 0)
        {
            
            if (index < 0 || index >= _pacientes.Length)
            {
                return new Paciente("Juan", 56, "9090876", "dengue"); // El paciente no se encontró en el arreglo.
            }

            if (_pacientes[index] != null && (_pacientes[index].nombre == ValorBusqueda || _pacientes[index].diagnostico == ValorBusqueda))
            {
               
                return _pacientes[index];
            }

            // Si no se encontró en esta posición, busca en la siguiente posición.
            return SearchPaciente(ValorBusqueda, index + 1);
        }



        public double[] Estadisticas()
        {
            double sumaEdades = 0;
            double promedio = 0;
            double numPacientes = 0;

            if (_indice <= 0)
            {
                return new double[2] { promedio, numPacientes };
            }

            // Verifica si _pacientes no está vacío antes de calcular el promedio
            if (_pacientes != null && _pacientes.Length > 0)
            {
                for (int i = 0; i < _indice; i++)
                {
                    sumaEdades += _pacientes[i].edad;
                }

                promedio = sumaEdades / _indice;
                promedio = Math.Round(promedio, 2);
            }

            numPacientes = _indice;

            return new double[2] { promedio, numPacientes };
        }


        public void LimpiarTextoBox( TextBox tbNombre, TextBox tbEdad, TextBox tbNumTel,
            TextBox tbDiagnostico)
        {
            tbNombre.Text = "";
            tbEdad.Text = "";
            tbNumTel.Text = "";
            tbDiagnostico.Text = "";

        }

        public void MostrarPacientes( ListBox listBox)
        {
            if (_indice <= 0)
                MessageBox.Show("Aun no hay pacientes registrados");
            for (int i = 0; i < _indice; i++)
            {
              
                listBox.Items.Add("Nombre: " + _pacientes[i].nombre);
                listBox.Items.Add("Edad: " + _pacientes[i].edad + " años");
                listBox.Items.Add("NumTel: " + _pacientes[i].numTelefono);
                listBox.Items.Add("Diagnostico: " + _pacientes[i].diagnostico);
                listBox.Items.Add("=================");
               

            
            }
        }


      

    }
}
