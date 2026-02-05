using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class Registro : Form
    {
        List<Persona> persona = new List<Persona>();
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona()
            {
                Nombre = txtNombre.Text, 
                Apellido = txtApellido.Text,
                Fecha = dateTimePicker1.Value
            });
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Registros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Registros.SelectedIndex==1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = persona;
            }
        }
    }
}
