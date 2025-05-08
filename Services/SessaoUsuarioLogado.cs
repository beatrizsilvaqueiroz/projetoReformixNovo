using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reformix.Models;

namespace Reformix.Services
{
    public static class SessaoUsuarioLogado
    {   
       public static Usuario _usuarioLogado { get; set; }

        public static void RegistrarUsuarioLogado(Usuario usuario) {

            _usuarioLogado = usuario;


        }
    }
}
