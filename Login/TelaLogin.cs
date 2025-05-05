using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.Criar_Conta_view;

namespace Reformix.Login

{

    public partial class TelaLogin : Form

    {

        public TelaLogin()

        {

            InitializeComponent();

        }

        private void lblLogin_Click(object sender, EventArgs e)

        {


        }

        private void btnEntrar_Click(object sender, EventArgs e)

        {

           

            MessageBox.Show("Login efetuado (exemplo).", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCriarConta_Click(object sender, EventArgs e)

        {

            MessageBox.Show("Funcionalidade de criação de conta em desenvolvimento.", "Em Desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)

        {

            MessageBox.Show("Funcionalidade de recuperação de senha em desenvolvimento.", "Em Desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TelaLogin_Load(object sender, EventArgs e)

        {

            

            txtSenha.UseSystemPasswordChar = true;

        }

        private void btnCriarConta_Click_1(object sender, EventArgs e)
        {
            CriarConta criarConta = new CriarConta();
            this.Close();
            criarConta.ShowDialog();
        }
    }

}

