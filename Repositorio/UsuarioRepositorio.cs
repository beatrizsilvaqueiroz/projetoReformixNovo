using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
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

            string query = @"INSERT INTO usuarios (Nome, Email, SenhaHash, Telefone)
                             VALUES (@Nome, @Email, @SenhaHash, @Telefone)";

            

            MySqlParameter[] parameters = {

                new MySqlParameter("@Nome", usuario.Nome),
                new MySqlParameter("@Email", usuario.Email),
                new MySqlParameter("@SenhaHash", Criptografia.HashPassword(usuario.SenhaHash)),
                new MySqlParameter("@Telefone", usuario.Telefone)

            };

            try
            {
                int linhasAfetadas = _databaseService.ExecuteNonQuery(query, parameters);
                return linhasAfetadas > 0;

            }
            catch (Exception ex) {
                throw new Exception("Erro ao executar consulta: " + ex.Message);
            }


            

        }


        public bool deletarUsuario(Usuario usuario)
        {

            string query = "DELETE FROM usuarios WHERE UsuarioID = @UsuarioID";



            MySqlParameter[] parameters = {

                new MySqlParameter("@UsuarioID", usuario.UsuarioID)

            };

            try
            {
                int linhasAfetadas = _databaseService.ExecuteNonQuery(query, parameters);
                return linhasAfetadas > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar usuário: " + ex.Message);
            }




        }

    }
}
