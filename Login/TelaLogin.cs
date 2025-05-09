using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.Controller;
using Reformix.Criar_Conta_view;
using Reformix.Models;
using Reformix.Repositorio;
using Reformix.Services;
using Reformix.Tela_Principal;

namespace Reformix.Login

{

    public partial class TelaLogin : Form

    {
        AuthService authService;
       private UsuarioController usuarioController;
        private TelaPrincipal _form;

        public TelaLogin(TelaPrincipal form)

        {

            InitializeComponent();
            DatabaseService databaseService = new DatabaseService();
            authService = new AuthService(databaseService);
            usuarioController = new UsuarioController(new UsuarioRepositorio(databaseService));
            this._form = form;
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

       

        private void btnCriarConta_Click_1(object sender, EventArgs e)
        {
            CriarConta criarConta = new CriarConta();
            this.Close();
            criarConta.ShowDialog();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
           Usuario usuario = authService.Authenticate(txtEmail.Text, txtSenha.Text);

            if (usuario == null) {
                MessageBox.Show("Erro ao realizar login");
                return;
            }

            SessaoUsuarioLogado.RegistrarUsuarioLogado(usuario);
            _form.ShowButtonHistorico();

            MessageBox.Show($"Login realizado! Olá {usuario.Nome}");
            this.Close();
        }

        private void btnEsqueceuSenha_Click_1(object sender, EventArgs e)
        {

            usuarioController.ExcluirConta(SessaoUsuarioLogado._usuarioLogado);
        }

        private void TelaLogin_Load_1(object sender, EventArgs e)
        {
           
            if (SessaoUsuarioLogado._usuarioLogado == null)
            {
                
                btnExcluirConta.Visible = false;
            }


            txtSenha.UseSystemPasswordChar = true;

        }
    }

}

