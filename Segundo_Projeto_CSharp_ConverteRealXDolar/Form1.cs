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
            //Definindo v�riais
            double cotacao;
            double valorReal;
            double valorDolar;

            //Lendo valores informados pelo usu�rio
            cotacao =  double.Parse(textBox1.Text);
            valorReal = double.Parse(textBox2.Text);
            valorDolar = valorReal / cotacao;

            //Mostrando Convers�o ao usu�rio
            label5.Text = valorDolar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Definindo v�riais
            double cotacao;
            double valorReal;
            double valorDolar;

            //Lendo valores informados pelo usu�rio
            cotacao = double.Parse(textBox1.Text);
            valorDolar = double.Parse(textBox3.Text);
            valorReal = valorDolar * cotacao;

            //Mostrando Convers�o ao usu�rio
            label6.Text = valorReal.ToString();
        }
    }
}
