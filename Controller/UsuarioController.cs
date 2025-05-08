using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.Models;
using Reformix.Repositorio;

namespace Reformix.Controller
{
    internal class UsuarioController
    {
        private UsuarioRepositorio usuarioRepositorio;

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public bool CriarUsuario(Usuario usuario) {

          bool resultadoCriacao = usuarioRepositorio.CriarUsuario(usuario);

            if (resultadoCriacao)
            {
                MessageBox.Show("Usuário criado com sucesso");
                return true;

            }
            else {

                MessageBox.Show("Erro na criação do usuário");


            }

            return false;
        
        } 
        
        public bool ExcluirConta(Usuario usuario) {

          bool resultadoExclusao = usuarioRepositorio.deletarUsuario(usuario);

            if (resultadoExclusao)
            {
                MessageBox.Show("Conta excluída com sucesso");
                return true;

            }
            else {

                MessageBox.Show("Erro na exclusão do usuário");


            }

            return false;
        
        }

    }
}
