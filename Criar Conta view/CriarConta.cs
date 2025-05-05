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
using Reformix.Models;
using Reformix.Repositorio;
using Reformix.Services;

namespace Reformix.Criar_Conta_view

{

    public partial class CriarConta : Form

    {
        private UsuarioController _usuarioController;
        private UsuarioRepositorio _usuarioRepositorio;
        private DatabaseService _databaseService;



        public CriarConta()

        {

            InitializeComponent();
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)

        {
            _databaseService = new DatabaseService();
            _usuarioRepositorio = new UsuarioRepositorio(_databaseService);
            _usuarioController = new UsuarioController(_usuarioRepositorio);

            Usuario usuario = new Usuario();
            usuario.Nome = txtNomeUsuario.Text;
            usuario.Email = txtEmail.Text;
            usuario.SenhaHash = txtSenha.Text;
            usuario.Telefone = mtbTelefone.Text;
                       


            if (string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.SenhaHash) ||

                string.IsNullOrEmpty(usuario.Nome) || !mtbTelefone.MaskFull)

            {

                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Atenção",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))

            {

                MessageBox.Show("E-mail inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            //_usuarioController.CriarUsuario(usuario);

            
            txtNomeUsuario.Clear();

            txtEmail.Clear();

            txtSenha.Clear();

            mtbTelefone.Clear();

        }

    }

}
