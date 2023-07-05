namespace ejercicioseudopruebaform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNRESULTADO_Click(object sender, EventArgs e)
        {
            int radio = int.Parse(boxradio.Text);
            int altura = int.Parse(Boxaltura.Text);
            if (radio > 0 && radio < 100)
            {
                if (altura > 0 && altura < 100)
                {
                    double generatriz = resultadogene(altura, radio);
                    double area = informacionarea(radio, generatriz);
                    double volumen = informacionvolumen(radio, altura);
                    MessageBox.Show($"el  area del cono es {area} y el volumen del cono es {volumen}", "resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Limpieza();

                }
                else
                {
                    MessageBox.Show($"la altura ingresada es menor a 0 o mayor de 100", "resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Limpieza();
                }

            }
            else 
            {
                MessageBox.Show($"la altura ingresada es menor a 0 o mayor de 100", "resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
                Limpieza();
            }
           
        }
        private double informacionvolumen(double radio, double altura)
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        private double informacionarea(double radio, double generatriz)
        {
            return Math.PI * radio * (radio + generatriz);
        }

        private double resultadogene(double altura, double radio)
        {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
        }

        private void Limpieza()
        {
            boxradio.Clear();
            Boxaltura.Clear();
            boxradio.Focus();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fin del Programa", "Salir",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿desea salir del formulario?", "pregunta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
    }
}