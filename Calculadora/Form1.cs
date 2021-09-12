using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "0"; // vai pegar o texto e acrescentar um 0
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "") {
            valor2 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
            } else
            {
                MessageBox.Show("Informe valores corretos.");
            }

            if (operacao == "SOMA")
            {
                txtBoxResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "SUB")
            {
                txtBoxResultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULT")
            {
                txtBoxResultado.Text = Convert.ToString(valor1 * valor2);
            } else if (operacao == "DIV")
            {
                    txtBoxResultado.Text = Convert.ToString(valor1 / valor2);
            } else
            {
                
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(txtBoxResultado.Text != "") {
            valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture); // colocando o valor 1 como o texto e convertendo para decimal
            // e o culture ta convertendo da forma certa sem ignorar o "."

            txtBoxResultado.Text = "";

            operacao = "SUB";

            lblOperacao2.Text = "-";
        }else
            {
                MessageBox.Show("Informe um valor válido.");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "") {
            valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture); // colocando o valor 1 como o texto e convertendo para decimal
            // e o culture ta convertendo da forma certa sem ignorar o "."

            txtBoxResultado.Text = "";

            operacao = "MULT";

            lblOperacao2.Text = "x";
            } else
            {
                MessageBox.Show("Informe um valor válido.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture); // colocando o valor 1 como o texto e convertendo para decimal
                                                                                            // e o culture ta convertendo da forma certa sem ignorar o "."

                txtBoxResultado.Text = "";

                operacao = "DIV";

                lblOperacao2.Text = "/";
            } else
            {
                MessageBox.Show("Informe um valor válido.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = "";
            lblOperacao2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = "";
            valor2 = 0;
            valor1 = 0;
            lblOperacao2.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture); // colocando o valor 1 como o texto e convertendo para decimal
                                                                                            // e o culture ta convertendo da forma certa sem ignorar o "."

                txtBoxResultado.Text = "";

                operacao = "SOMA";

                lblOperacao2.Text = "+";
            } else
            {
                MessageBox.Show("Informe um valor válido.");
            }            
        }
    }
}
