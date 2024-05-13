using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Por ter mais conhecimento em java, eu fui pesquisar se era existias algumas coisas
//e após pesquisar na documentação de C# eu descobri algumas,
//como IsDigit, IsLetter, IsNaN, Replace.


//Referencias usadadas abaixo:

//https://learn.microsoft.com/pt-br/dotnet/api/system.string.isnullorempty?view=net-8.0
//https://learn.microsoft.com/en-us/dotnet/api/system.char.isdigit?view=net-8.0
//https://learn.microsoft.com/en-us/dotnet/api/system.char.isletter?view=net-8.0
//https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.replace?view=net-8.0

namespace apCalculadora
{
    public partial class apCalculadora : Form
    {
        public apCalculadora()
        {
            InitializeComponent();

        }

        string infixa = "";
        string[] letras;

       
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (verificarInfixa() == false)
            {
                return;
            }

            double[] valores = ExtrairValoresNumericos(infixa);
            string[] letras = AtribuirLetras(valores);
            string infixaComLetras = SubstituirNumerosporLetras(infixa, valores, letras);

            string expressaoPosfixa = ConverterInfixaparaPosfixa(infixaComLetras);
            double resultado = CalcularExpressaoPosfixa(expressaoPosfixa, valores, letras);

            if (double.IsNaN(resultado))
            {
                txtResultado.Text = "Erro: Operação inválida";
            }
            else
            {
                lbPosfixa.Text = "Pósfixa: " + expressaoPosfixa;
                txtResultado.Text = resultado.ToString();
            }
            

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            infixa = default;
            txtResultado.Text = "";
            txtVisor.Text = "";
            lbPosfixa.Text = default;
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            infixa += "(";
            txtVisor.Text = infixa;

        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            infixa += ")";
            txtVisor.Text = infixa;
            verificarInfixa();
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            infixa += ".";
            txtVisor.Text = infixa;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            infixa += "-";
            txtVisor.Text = infixa;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            infixa += "*";
            txtVisor.Text = infixa;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            infixa += "/";
            txtVisor.Text = infixa;
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            infixa += "^";
            txtVisor.Text = infixa;
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            infixa += "1";
            txtVisor.Text = infixa;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            infixa += "2";
            txtVisor.Text = infixa;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            infixa += "3";
            txtVisor.Text = infixa;
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            infixa += "4";
            txtVisor.Text = infixa;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            infixa += "5";
            txtVisor.Text = infixa;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            infixa += "6";
            txtVisor.Text = infixa;
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            infixa += "7";
            txtVisor.Text = infixa;
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
            infixa += "8";
            txtVisor.Text = infixa;
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            infixa += "9";
            txtVisor.Text = infixa;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            infixa += "0";
            txtVisor.Text = infixa;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            infixa += "+";
            txtVisor.Text = infixa;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Programação dos metódos começa aqui.

        private bool verificarInfixa()
        {
            // Verificar se a expressão está vazia ou contém apenas espaços em branco usando  o .Trim()
            if (infixa == null || infixa.Trim().Length == 0)
            {
                MessageBox.Show("Por favor, insira uma expressão.", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            char[] operadores = { '+', '-', '*', '/', '^'};
            if (operadores.Contains(infixa[infixa.Length - 1]))
            {
                MessageBox.Show("A expressão não pode terminar com um operador.", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Verificação do numero de parentesês
            int countParenteses = 0;
            foreach (char caractere in infixa)
            {
                if (caractere == '(')
                    countParenteses++;
                else if (caractere == ')')
                    countParenteses--;

                if (countParenteses < 0)
                {
                    MessageBox.Show("A expressão contém parênteses desbalanceados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (countParenteses != 0)
            {
                MessageBox.Show("A expressão contém parênteses desbalanceados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private int ObterPrecedencia(char operador)
        {
            switch (operador)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        private double[] ExtrairValoresNumericos(string expressao)
        {
            List<double> valores = new List<double>();
            string numeroAtual = "";
            char ponto = '.';
            

            foreach (char caractere in expressao)
            {
                if (char.IsDigit(caractere) || caractere == ponto)
                {
                    numeroAtual += caractere;
                }
                else
                {
                    if (!string.IsNullOrEmpty(numeroAtual))
                    {
                        //CultureInfo.InvariantCulture é usada para formatação de números com um ponto como separador decimal.

                        valores.Add(Double.Parse(numeroAtual, CultureInfo.InvariantCulture));
                        numeroAtual = "";
                    }
                }
            }

            if (!string.IsNullOrEmpty(numeroAtual))
            {
                valores.Add(Double.Parse(numeroAtual, CultureInfo.InvariantCulture));
            }

            return valores.ToArray();
        }

        private string[] AtribuirLetras(double[] valores)
        {
            letras = new string[valores.Length];
            for (int i = 0; i < valores.Length; i++)
            {
                letras[i] = (((char)('a' + i)).ToString()).ToUpper(); //deixei em maiúsculas, usando o ToUpper.
            }
            return letras;
        }

        private string SubstituirNumerosporLetras(string expressao, double[] valores, string[] letras)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                string valorString = valores[i].ToString(CultureInfo.InvariantCulture); 
                expressao = expressao.Replace(valorString, letras[i]); 
            }
            return expressao;
        }



        private string ConverterInfixaparaPosfixa(string expressao)
        {
            string posfixa = "";
            PilhaVetor<char> pilhaOperadores = new PilhaVetor<char>();

            foreach (char caractere in expressao)
            {
                if (char.IsLetter(caractere))
                {
                    posfixa += caractere;
                }
                else if (caractere == '(')
                {
                    pilhaOperadores.Empilhar(caractere);
                }
                else if (caractere == ')')
                {
                    while (pilhaOperadores.OTopo() != '(')
                    {
                        posfixa += pilhaOperadores.Desempilhar();
                    }
                    pilhaOperadores.Desempilhar(); // Remover o '(' da pilha
                }
                else
                {
                    while (!pilhaOperadores.EstaVazia &&
                        ObterPrecedencia(pilhaOperadores.OTopo()) >= ObterPrecedencia(caractere))
                    {
                        posfixa += pilhaOperadores.Desempilhar();
                    }

                    pilhaOperadores.Empilhar(caractere);
                }
            }

            while (!pilhaOperadores.EstaVazia)
            {
                posfixa += pilhaOperadores.Desempilhar();
            }

            return posfixa;
        }



        private double CalcularExpressaoPosfixa(string expressao, double[] valores, string[] letras)
        {
            PilhaVetor<double> pilhaValores = new PilhaVetor<double>();

            foreach (char caractere in expressao)
            {
                if (char.IsLetter(caractere))
                {
                    //ToLower porque letras maiusculas e minusculas se diferenciam na tabela ASCII
                    int indice = char.ToLower(caractere) - 'a'; 
                    pilhaValores.Empilhar(valores[indice]);
                }
                else
                {
                    double operando2 = pilhaValores.Desempilhar();
                    double operando1 = pilhaValores.Desempilhar();

                    switch (caractere)
                    {
                        case '+':
                            pilhaValores.Empilhar(operando1 + operando2);
                            break;
                        case '-':
                            pilhaValores.Empilhar(operando1 - operando2);
                            break;
                        case '*':
                            pilhaValores.Empilhar(operando1 * operando2);
                            break;
                        case '/':
                            pilhaValores.Empilhar(operando1 / operando2);
                            break;
                        case '^':
                            pilhaValores.Empilhar(Math.Pow(operando1, operando2));
                            break;
                    }
                }
            }
            return pilhaValores.Desempilhar();
        }

        

        private void txtVisor_Leave(object sender, EventArgs e)
        {
            string novoTexto = "";
            foreach (char c in txtVisor.Text)
            {
                if (!char.IsLetter(c))
                {
                    novoTexto += c;
                }
                else
                {
                    MessageBox.Show("Não é possivel atribuir letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            txtVisor.Text = novoTexto;
            txtVisor.SelectionStart = novoTexto.Length;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
