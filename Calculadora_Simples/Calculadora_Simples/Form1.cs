//Link do Video -> https://www.youtube.com/watch?v=BxhTP_Ja_Oo

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Operacao = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            bool Validacao = Verificacoes();
            if (!Validacao)
            {
                double Numero1;
                double Numero2;
                double Resultado = 0;

                //Converter os valores para double
                Numero1 = double.Parse(txt_Valor1.Text);
                Numero2 = double.Parse(txt_Valor2.Text);

                //Executa a opera��o, consoante a selecionada
                if (Operacao == 1)
                {
                    Resultado = Numero1 + Numero2;
                }
                if (Operacao == 2)
                {
                    Resultado = Numero1 - Numero2;
                }
                if (Operacao == 3)
                {
                    Resultado = Numero1 * Numero2;
                }
                if (Operacao == 4)
                {
                    Resultado = Numero1 / Numero2;
                }
                txt_Resultado.Text = Resultado.ToString();
            }
        }

        private void rb_Soma_CheckedChanged(object sender, EventArgs e)
        {
            Operacao = 1;
        }

        private void rb_Subtra��o_CheckedChanged(object sender, EventArgs e)
        {
            Operacao = 2;
        }

        private void rd_Multiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            Operacao = 3;
        }

        private void rb_Divisao_CheckedChanged(object sender, EventArgs e)
        {
            Operacao = 4;
        }

        private bool Verificacoes()
        {
            //Verifca��o TextBoxs preenchidas
            if (string.IsNullOrWhiteSpace(txt_Valor1.Text)
                || string.IsNullOrWhiteSpace(txt_Valor2.Text))
            {
                MessageBox.Show("Todas as TextBox tem de estar preenchidas.", "Valores Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            //Verifica se alguma das opera��es foi selecionada
            if (Operacao == 0)
            {
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
