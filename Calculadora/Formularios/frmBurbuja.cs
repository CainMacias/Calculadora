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

namespace Calculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenamientos ordenamientos = new Ordenamientos();
            int[] ordenado = new int[dataGridView1.RowCount - 1];

            //Cargar el array con los datos del datagridview1
            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                ordenado[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            }

            ordenado = ordenamientos.Burbuja(ordenado);

            dataGridView2.DataSource = ordenado;

            for(int i = 0; i < ordenado.Length; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = ordenado[i];
            }

        }
    }
}
