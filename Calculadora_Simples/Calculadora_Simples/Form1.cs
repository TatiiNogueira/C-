//Link do Video -> https://www.youtube.com/watch?v=BxhTP_Ja_Oo

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //M�todo � gerado automaticamente pelo designer do Windows Forms
            //Inicializar todos os controles do formul�rio
            InitializeComponent();
        }

        // Propriedades para armazenar os valores
        public double Numero1 { get; private set; }
        public double Numero2 { get; private set; }
        public double Resultado { get; private set; }


        private void button1_Click(object sender, EventArgs e)
        {
            bool Validacao = Verificacoes();
            if (!Validacao)
            {
                txt_Resultado.Text = Resultado.ToString();
            }
        }

        public async Task Valores_Doubles()
        {
            //Converter os valores para double(decimais)
            Numero1 = double.Parse(txt_Valor1.Text);
            Numero2 = double.Parse(txt_Valor2.Text);
        }

        private void rb_Soma_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 + Numero2;
        }

        private void rb_Subtra��o_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 - Numero2;
        }

        private void rd_Multiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 * Numero2;
        }

        private void rb_Divisao_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 / Numero2;
        }

        private bool Verificacoes()
        {
            //if (string.IsNullOrEmpty(txt_Valor1.Text))
            //{
            //    MessageBox.Show("mensagem", "Titlo");
            //    return true; 
            //}

            //if (!rb_Soma.Checked)
            //{
            //}

            //if (!double.TryParse(txt_Valor2.Text, out _))
            //{

            //}
            //Verifca��o TextBoxs preenchidas
            if (string.IsNullOrWhiteSpace(txt_Valor1.Text)
                || string.IsNullOrWhiteSpace(txt_Valor2.Text))
            {
                MessageBox.Show("Todas as TextBox tem de estar preenchidas.", "Valores Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            //Verifica se alguma das opera��es foi selecionada
            if (!rb_Soma.Checked && 
                !rb_Subtra��o.Checked &&
                !rb_Multiplicacao.Checked &&
                !rb_Divisao.Checked){
                MessageBox.Show("Dever� selecionar a opera��o desejada", "Opera��o n�o Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // Verifica se o valor � um n�mero
            if (!double.TryParse(txt_Valor1.Text, out _)
                || !double.TryParse(txt_Valor2.Text, out _))
            {
                MessageBox.Show("Todos os valores tem de ser n�meros.", "Valores Inv�idos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;

            }
            return false;
        }
    }
}
