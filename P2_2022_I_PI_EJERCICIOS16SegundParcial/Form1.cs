namespace P2_2022_I_PI_EJERCICIOS16SegundParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal montoPrincipal = decimal.Parse(txtmontoprincipal.Text);
            double tasainteres = double.Parse(txttazadeinteres.Text);
            int ano = (int) 
                string salida = "Ano\t monto a depositar\n";


            for (int contadorAno = 0; contadorAno < ano; contadorAno++)
            {
                decimal montoDeposito = montoPrincipal *
                    ((decimal)Math.Pow(1 + tasainteres/ 100,contadorAno));
                Salida += $"{contadorAno}\t{montoDeposito:c}\r\n";
            }

           
        }
    }
}