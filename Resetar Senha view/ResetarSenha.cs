using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix.Resetar_Senha_view
{
    public partial class ResetarSenha : Form
    {
        public ResetarSenha()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, informe um e-mail.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            MessageBox.Show("Instruções para redefinir sua senha foram enviadas para o e-mail informado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            txtEmail.Clear();
        }

        private void lnkVoltarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            MessageBox.Show("Tela de login em desenvolvimento.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}