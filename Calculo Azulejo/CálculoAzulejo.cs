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

namespace Reformix.Cálculo_Azulejo
{
    public partial class CalculoAzulejo : Form
    {
        public CalculoAzulejo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double paredeAltura = double.Parse(txtParedeAltura.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                double paredeLargura = double.Parse(txtParedeLargura.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                double azulejoAltura = double.Parse(txtAzulejoAltura.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                double azulejoLargura = double.Parse(txtAzulejoLargura.Text.Replace(",", "."), CultureInfo.InvariantCulture);

                double areaParede = paredeLargura * paredeAltura;
                double areaAzulejo = azulejoLargura * azulejoAltura;

                if (areaAzulejo <= 0)
                {
                    MessageBox.Show("As dimensões do azulejo devem ser maiores que zero.");
                    return;
                }

                double quantidade = areaParede / areaAzulejo;
                int quantidadeFinal = (int)Math.Ceiling(quantidade * 1.1);

                lblResult.Text = $"Área da parede: {areaParede:F2} m²\n" +
                                 $"Azulejos necessários (com 10% extra): {quantidadeFinal}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
