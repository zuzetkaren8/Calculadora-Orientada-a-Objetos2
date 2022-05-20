namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        String resultado;
        double total;
        double numero1;
        double numero2;
        String signo;
        sumar sum = new sumar();
        restar res = new restar();
        multiplicar mul = new multiplicar();
        dividir div = new dividir();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado = "";
            textBox1.Text =resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numero;
            numero = Convert.ToString(((Button)sender).Text);
            resultado = resultado + numero;
            textBox1.Text = resultado.ToString();
        }

        private void buttonLimpiar(object sender, EventArgs e)
        {
            resultado = "";
            textBox1.Text = resultado.ToString();
        }

        private void buttonIgual(object sender, EventArgs e)
        {
            numero2 = Convert.ToInt32(textBox1.Text);
            switch (signo)
            {
                case "+":
                    total = sum.suma(numero1, numero2);
                    textBox1.Text = total.ToString();
                    break;
                case "-":
                    total = res.resta(numero1, numero2);
                    textBox1.Text = total.ToString();
                    break;
                case "*":
                    total = mul.multiplica(numero1, numero2);
                    textBox1.Text = total.ToString();
                    break;
                case "/":
                    total = div.divide(numero1, numero2);
                    textBox1.Text = total.ToString();
                    break;

            }
        }

        private void buttonSuma(object sender, EventArgs e)
        {
            numero1=Convert.ToDouble(textBox1.Text);
            textBox1.Text = "+";
            signo = "+";
            resultado = "";
        }

        private void buttonResta(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "-";
            signo = "-";
            resultado = "";
        }

        private void buttonMultiplicacion(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "*";
            signo = "*";
            resultado = "";
        }

        private void buttonDivision(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "/";
            signo = "/";
            resultado = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String u;
            u = Convert.ToString(((Button)sender).Text);
            resultado = resultado + u;
            textBox1.Text = resultado.ToString();
        }
    }
}