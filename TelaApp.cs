using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdisraBrasils;
using System.Windows.Forms;

namespace AdisraBrasils
{
    public partial class TelaApp : Form
    {
        float pedido;

        public TelaApp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertDolar_Click(object sender, EventArgs e)
        {

            float dolars = float.Parse(this.textBox1.Text);

            double reais = dolars * 5.36;

            listView1.Items.Add($"R$ {reais}".ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sequencia_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            string numeros = this.textBox2.Text;
            int[] lista = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                lista[i] = int.Parse(numeros[i].ToString());
            }
            bool repetidos = false;

            var contagem = lista
             .GroupBy(x => x)
             .Where(g => g.Count() > 1)
             .OrderByDescending(x => x.Count())
             .Select(x => new { Número = x.Key, Quantidade = x.Count() })
             .ToList();
            listView2.Items.Add(contagem[0].ToString());

            for (var x = 0; x < lista.Length; x++)
            {
                int a = lista[x];
                int c = x + 1;
                for (int y = c; y < lista.Length; y++)
                {
                    int b = lista[y];
                    if (a == b)
                    {
                        repetidos = true;
                    }
                }
            }
            if (repetidos == false)
            {
                listView2.Items.Add("Sem números repetidos na lista.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            pedido = 0;
            listView3.Items.Add($"Valor Total R$ {pedido},00".ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string printGolomb(int n)
            {
                int[] dp = new int[n + 1];

                // base cases
                dp[1] = 1;
                string resul = (dp[1] + " ");

                // Finding and printing first n
                // terms of Golomb Sequence.
                for (int i = 2; i <= n; i++)
                {
                    dp[i] = 1 + dp[i - dp[dp[i - 1]]];
                    resul += (dp[i] + " ");
                }
                return resul;
            }
            var value = this.textBox3.Text;
            listView4.Items.Add(printGolomb(Int32.Parse(value)).ToString());

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void fazerPedido_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            decimal pedido = 0;
            pedido += numericUpDown1.Value * 20;
            pedido += numericUpDown2.Value * 16;
            pedido += numericUpDown3.Value * 4;
            pedido += numericUpDown4.Value * 6;
            pedido += numericUpDown5.Value * 2;
            pedido += numericUpDown6.Value * 1;
            listView3.Items.Add($"Valor Total R${pedido},00".ToString());
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    } 
}
