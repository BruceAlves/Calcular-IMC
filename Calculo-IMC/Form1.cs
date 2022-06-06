using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double imc = peso / (altura * altura);

            string classificação = string.Empty;

            if(imc < 18.5)
            {
                classificação = "Baixo Peso";
            }
            else if(imc > 18.6 && imc < 24.9)
            {
                classificação = "Peso Normal";
            }
            else if (imc > 25 && imc < 29.9)
            {
                classificação = "Sobrepeso";
            }
            else if (imc > 30 && imc < 34.9)
            {
                classificação = "Obsidade Grau 1";
            }
            else if (imc > 35 && imc < 39.9)
            {
                classificação = "Obsidade Grau 2";
            }
            else
            {
                classificação = "Obsidade Grau 3";
            }

            

            MessageBox.Show($"Seu IMC é {imc.ToString("F")} \n{classificação}","Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPeso.Text = string.Empty;
            txtAltura.Text = string.Empty;
            
        }
    }
}
