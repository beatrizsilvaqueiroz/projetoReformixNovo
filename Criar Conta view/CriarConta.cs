using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix.Criar_Conta_view

{

    public partial class CriarConta : Form

    {

        public CriarConta()

        {

            InitializeComponent();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)

        {

            string usuario = txtUsuario.Text.Trim();

            string email = txtEmail.Text.Trim();

            string senha = txtSenha.Text;

            string telefone = mtbTelefone.Text.Trim();


            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(email) ||

                string.IsNullOrEmpty(senha) || !mtbTelefone.MaskFull)

            {

                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Atenção",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            if (!email.Contains("@") || !email.Contains("."))

            {

                MessageBox.Show("E-mail inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso",

                MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtUsuario.Clear();

            txtEmail.Clear();

            txtSenha.Clear();

            mtbTelefone.Clear();

        }

    }

}
