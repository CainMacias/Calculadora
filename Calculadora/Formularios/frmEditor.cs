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
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        bool saved = false;
        string path = "";


        private void frmEditor_Load(object sender, EventArgs e)
        {

        }
        private void Guardar()
        {
            if(ofdEditor.ShowDialog() == DialogResult.OK)
            {
                path = ofdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(sfdEditor.FileName))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdEditor.FileName))
                {
                    
                    rtbEditor.Text = File.ReadAllText(ofdEditor.FileName);


                }
            }
        }

        

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }


        
    }
}
