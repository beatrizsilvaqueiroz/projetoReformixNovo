using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Reformix.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string Telefone { get; set; }


        public static Usuario UserFromDataReader(MySqlDataReader reader)
        {

            return new Usuario
            {
                UsuarioID = Convert.ToInt32(reader["UsuarioID"].ToString()),
                Nome = reader["Nome"].ToString(),
                Email = reader["Email"].ToString(),
                SenhaHash = reader["SenhaHash"].ToString(),
                
            };


        }


    }
}
