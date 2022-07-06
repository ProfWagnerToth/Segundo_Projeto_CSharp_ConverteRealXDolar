namespace Segundo_Projeto_CSharp_ConverteRealXDolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo váriais
            double cotacao;
            double valorReal;
            double valorDolar;

            //Lendo valores informados pelo usuário
            cotacao =  double.Parse(textBox1.Text);
            valorReal = double.Parse(textBox2.Text);
            valorDolar = valorReal / cotacao;

            //Mostrando Conversão ao usuário
            label5.Text = valorDolar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Definindo váriais
            double cotacao;
            double valorReal;
            double valorDolar;

            //Lendo valores informados pelo usuário
            cotacao = double.Parse(textBox1.Text);
            valorDolar = double.Parse(textBox3.Text);
            valorReal = valorDolar * cotacao;

            //Mostrando Conversão ao usuário
            label6.Text = valorReal.ToString();
        }
    }
}
