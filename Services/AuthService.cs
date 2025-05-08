using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Reformix.Models;

namespace Reformix.Services
{
   

        public class AuthService
        {
            private readonly DatabaseService _databaseService;

            public AuthService(DatabaseService databaseService)
            {
                _databaseService = databaseService;
            }

            public Usuario Authenticate(string email, string password)
            {
                try
                {
                    // Primeiro busca o usuário pelo email
                    string query = "SELECT * FROM usuarios WHERE email = @emailDigitado";
                    var parameters = new MySqlParameter[]
                    {

                    new MySqlParameter("@emailDigitado", email),
                    

                    };

                    using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                    {
                        if (respostaBanco.Read())

                        {
                            // Verifica a senha
                            string storedHash = respostaBanco["SenhaHash"].ToString();
                            string inputHash = Criptografia.HashPassword(password);

                            if (storedHash == inputHash)
                            {
                                Usuario usuario = new Usuario();
                                usuario = Usuario.UserFromDataReader(respostaBanco);

                                return usuario;
                            }
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro durante autenticação: " + ex.Message);
                }
            }




        }

    
}
