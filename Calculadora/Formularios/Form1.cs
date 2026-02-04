namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void variableA_Click(object sender, EventArgs e)
        {

        }

        private void TnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;

                a = Convert.ToInt32(textVarA.Text);
                b = int.Parse(textVarB.Text);

                if (Suma.Checked)          
                    resultado = a + b;
                if (Resta.Checked)
                    resultado = a - b;
                if (Multiplicacion.Checked)
                    resultado = a * b;
                if (Division.Checked)
                    resultado = a / b;


                MessageBox.Show("El resultado de la suma es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textResultado.Text = resultado.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + MessageBoxIcon.Warning);


            }
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            textVarA.Text = "";
            textVarB.Clear();
        }
    }
}
