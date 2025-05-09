using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.Models;
using Reformix.Repositorio;
using Reformix.Services;

namespace Reformix.Estimador_de_Tinta
{
    public partial class EstimadorTinta : Form
    {
        private HistoricoRepositorio historicoRepositorio;
        public EstimadorTinta()
        {
            InitializeComponent();
            historicoRepositorio = new HistoricoRepositorio(new DatabaseService());

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAmbiente.Text))
                {
                    MessageBox.Show("Você precisa informar o ambiente");
                    return;
                    
                }
                double area = double.Parse(txtAreaParede.Text);
                int demaos = int.Parse(txtDemao.Text);
                double cobertura = double.Parse(txtCoberturaTinta.Text);

                double quantidadeTinta = (area * demaos) / cobertura;

                lblResultado.Text = $"Quantidade estimada de tinta: {quantidadeTinta:F2} litros";
                lblResultado.Visible = false;
                MessageBox.Show(lblResultado.Text);

                if (SessaoUsuarioLogado._usuarioLogado != null)
                {
                    btnSalvar.Visible = true;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Calculo calculo = new Calculo();

            calculo.Data = DateTime.Now;
            calculo.Ambiente = txtAmbiente.Text;
            calculo.Operacao = "Estimativa de tinta";
            calculo.MaterialNecessario = $"{lblResultado.Text}";

            bool resultadoRegistro = historicoRepositorio.RegistrarCalculo(calculo);

            if (resultadoRegistro)
            {

                MessageBox.Show("Cálculo registrado com sucesso!");
                return;

            }
            MessageBox.Show("Cálculo não registrado");
            return;
        }

        private void EstimadorTinta_Load(object sender, EventArgs e)
        {
            btnSalvar.Visible = false;

            if (SessaoUsuarioLogado._usuarioLogado == null)
            {
                btnSalvar.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
