using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Reformix.Models;
using Reformix.Services;

namespace Reformix.Repositorio
{
    public class UsuarioRepositorio
    {

        private DatabaseService _databaseService;

        public UsuarioRepositorio(DatabaseService databaseService)
        {
            this._databaseService = databaseService;
        }

        public bool CriarUsuario(Usuario usuario) {

            string query = @"INSERT into usuarios (Nome, Email, SenhaHash, Telefone)
                             VALUES (@Nome, )";

            MySqlParameter[] parameters = {

                new MySqlParameter("@Nome", usuario.Nome),
                new MySqlParameter("@Email", usuario.Email),
                new MySqlParameter("@SenhaHash", Criptografia.HashPassword(usuario.SenhaHash)),
                new MySqlParameter("@Telefone", usuario.Telefone),

            };

            try
            {
                int linhasAfetadas = _databaseService.ExecuteNonQuery(query, parameters);
                return linhasAfetadas > 0;

            }
            catch {
                return false;
            }

            

        }
    }
}
