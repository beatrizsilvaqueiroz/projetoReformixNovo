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
using Reformix.Models;
using Reformix.Repositorio;
using Reformix.Services;

namespace Reformix.Cálculo_Azulejo
{
    public partial class CalculoAzulejo : Form
    {
        private HistoricoRepositorio historicoRepositorio;
        public CalculoAzulejo()
        {
            InitializeComponent();
            historicoRepositorio = new HistoricoRepositorio(new DatabaseService());
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
                lblResult.Visible = false;
                MessageBox.Show(lblResult.Text);
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculo calculo = new Calculo();

            calculo.Operacao = "Cálculo de azulejos";
            calculo.MaterialNecessario = $"{lblResult.Text} azulejos";

           bool resultadoRegistro = historicoRepositorio.RegistrarCalculo(calculo);

            if (resultadoRegistro) {

                MessageBox.Show("Cálculo registrado com sucesso!");
                return;
            
            }
            MessageBox.Show("Cálculo não registrado");
            return;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void CalculoAzulejo_Load(object sender, EventArgs e)
        {
            if (SessaoUsuarioLogado._usuarioLogado == null)
            {
                button2.Visible = false;
            }
        }
    }
}
