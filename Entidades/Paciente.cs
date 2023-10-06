using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPrimerParcial.Entidades
{
    public class Paciente
    {
        public string nombre { get; set; }
        public  int edad { get; set; }
        public  string numTelefono { get; set; }
        public string diagnostico { get; set; }


        public Paciente(string nombre, int edad, string numTelefono, string diagnostico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.numTelefono = numTelefono;
            this.diagnostico = diagnostico;
        }

        public void  ShowPacientes( ListBox listBox,Paciente paciente)
        {
            listBox.Items.Add("Nombre: " + paciente.nombre);
            listBox.Items.Add("Edad: " + paciente.edad + " años");
            listBox.Items.Add("NumTel: " + paciente.numTelefono);
            listBox.Items.Add("Diagnostico: " + paciente.diagnostico);
            listBox.Items.Add("=================");
        }


    }
}
