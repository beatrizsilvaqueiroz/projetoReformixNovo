using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.TelaPerfil;
using Reformix.Tema;

namespace Reformix.Configuracoes
{
    public partial class TelaConfiguracoes : Form
    {
        private bool notificacoesAtivadas = true;

        public TelaConfiguracoes()
        {
            InitializeComponent();
            InicializarComponentes();
            CarregarConfiguracoes();
        }

        private void InicializarComponentes()
        {
            // ComboBox de Tema
            cbTema.Items.Clear();
            cbTema.Items.Add("Claro");
            cbTema.Items.Add("Escuro");

            // ComboBox de Notificações
            cbNotificacoes.Items.Clear();
            cbNotificacoes.Items.Add("Ativado");
            cbNotificacoes.Items.Add("Desativado");

            // Botões com texto atualizado
            btnEditarPerfil.Text = "Editar";
            btnVerHistorico.Text = "Ver histórico completo";
            btnVoltar.Text = "Voltar";
            btnExcluirConta.Text = "Excluir conta";
            btnSalvarTudo.Text = "Salvar Tudo";

            // Eventos
            btnEditarPerfil.Click += BtnPerfil_Click;
            btnVerHistorico.Click += BtnHistorico_Click;
            btnVoltar.Click += BtnVoltar_Click;
            btnExcluirConta.Click += BtnExcluirConta_Click;
            btnSalvarTudo.Click += BtnSalvarTudo_Click;
        }

        private void CarregarConfiguracoes()
        {
            string temaSalvo = Properties.Settings.Default.Tema;
            string notificacaoSalva = Properties.Settings.Default.Notificações;

            if (!string.IsNullOrEmpty(temaSalvo) && cbTema.Items.Contains(temaSalvo))
                cbTema.SelectedItem = temaSalvo;
            else
                cbTema.SelectedItem = "Claro";

            if (!string.IsNullOrEmpty(notificacaoSalva) && cbNotificacoes.Items.Contains(notificacaoSalva))
                cbNotificacoes.SelectedItem = notificacaoSalva;
            else
                cbNotificacoes.SelectedItem = "Ativado";

            GerenciadorTema.AplicarTema(this, cbTema.SelectedItem.ToString());
        }

        private void BtnSalvarTudo_Click(object sender, EventArgs e)
        {
            string temaSelecionado = cbTema.SelectedItem?.ToString() ?? "Claro";
            string notificacoesSelecionadas = cbNotificacoes.SelectedItem?.ToString() ?? "Ativado";

            Properties.Settings.Default.Tema = temaSelecionado;
            Properties.Settings.Default.Notificações = notificacoesSelecionadas;
            Properties.Settings.Default.Save();

            GerenciadorTema.AplicarTema(this, temaSelecionado);

            MessageBox.Show($"Configurações salvas:\nTema: {temaSelecionado}\nNotificações: {notificacoesSelecionadas}");
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir o histórico completo");
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluirConta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir sua conta?", "Excluir Conta", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Conta excluída com sucesso.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}