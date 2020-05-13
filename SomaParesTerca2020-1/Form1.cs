using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaParesTerca2020_1
{
    public partial class FrmSoma : Form
    {
        public FrmSoma()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Criando as variáveis que receberão o número digitado e a soma
            int num = 0, multiplo = 0, soma = 0;

            // Captando o número digitado e jogando na variável num

            // checando se os valores digitados são realmente números inteiros
            bool numValido;
            bool multiploValido;
            numValido = int.TryParse(txtNum.Text, out num);
            multiploValido = int.TryParse(txtMultiplo.Text, out multiplo);


            // se num for diferente de 0 e múltiplo igual a 0,
            // Calcula a soma dos pares
            if (num != 0 && multiplo == 0)
            {
                // Criando a estrutura de repetição do código que fará a soma
                for (int i = 1; i <= num; i++)
                {
                    // checando se i é par
                    if (i % 2 == 0)
                    {
                        // somando o que está na variável soma com o valor de i
                        soma = soma + i; // pode ser escrito como soma += i
                        // Checar os passos da soma
                        Console.WriteLine("Número: " + i + ". Soma: " + soma);
                    }
                }

                // jogando o total da soma no txtSoma
                txtSoma.Text = soma.ToString();
            }// se num for diferente de 0 e múltiplo também,
            // Calcula a soma dos múltiplos
            else if (num != 0 && multiplo != 0)
            {
                // Criando a estrutura de repetição do código que fará a soma
                for (int i = 1; i <= num; i++)
                {
                    // checando se i é múltiplo do número informado
                    if (i % multiplo == 0)
                    {
                        // somando o que está na variável soma com o valor de i
                        soma = soma + i; // pode ser escrito como soma += i
                        // Checar os passos da soma
                        Console.WriteLine("Número: " + i + ". Soma: " + soma);
                    }
                }

                // jogando o total da soma no txtSoma
                txtSoma.Text = soma.ToString();

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando os controles para novo cálculo
            txtSoma.Clear();
            txtNum.Clear();
            txtMultiplo.Clear();

        }
    }
}
