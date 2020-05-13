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
            int num, soma = 0;

            // Captando o número digitado e jogando na variável num
            num = Convert.ToInt32(txtNum.Text);

            // Criando a estrutura de repetição do código que fará a soma
            for (int i = 1; i <= num; i++)
            {
                // checando se i é par
                if (i % 2 == 0)
                {
                    // somando o que está na variável soma com o valor de i
                    soma = soma + i; // pode ser escrito como soma += i
                    // Checar os passos da soma
                    Console.WriteLine("Número: "+ i + ". Soma: " + soma);
                }
            }
            // jogando o total da soma no txtSoma
            txtSoma.Text = soma.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando os controles para novo cálculo
            txtSoma.Clear();
            txtNum.Clear();

        }
    }
}
