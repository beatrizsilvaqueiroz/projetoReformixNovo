using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Reformix.Models;
using Reformix.Services;

namespace Reformix.Repositorio
{
    internal class HistoricoRepositorio
    {
        private DatabaseService databaseService;

        public HistoricoRepositorio(DatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public bool RegistrarCalculo(Calculo calculo)
        {

            string query = @"INSERT INTO historicooperacoes (UsuarioID, Operacao, material_necessario, ambiente)
                             VALUES (@UsuarioID, @Operacao, @material_necessario, @Ambiente)";



            MySqlParameter[] parameters = {

                new MySqlParameter("@Ambiente", calculo.Ambiente),
                new MySqlParameter("@UsuarioID", SessaoUsuarioLogado._usuarioLogado.UsuarioID),
                new MySqlParameter("@Operacao", calculo.Operacao),
                new MySqlParameter("@material_necessario", calculo.MaterialNecessario),

            };

            try
            {
                int linhasAfetadas = databaseService.ExecuteNonQuery(query, parameters);
                return linhasAfetadas > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar consulta: " + ex.Message);
            }




        }

        public List<Calculo> getAllCalculos()
        {
            List<Calculo> listCalculos = new List<Calculo>();
            try
            {
                // Primeiro busca o usuário pelo email
                string query = "SELECT * FROM historicooperacoes WHERE UsuarioID = @UsuarioID";
                var parameters = new MySqlParameter[]
                {

                    new MySqlParameter("@UsuarioID", SessaoUsuarioLogado._usuarioLogado.UsuarioID),
                    //new MySqlParameter("@UsuarioID", SessaoUsuarioLogado._usuarioLogado.UsuarioID),


                };

                using (var respostaBanco = databaseService.ExecuteQuery(query, parameters))
                {
                    while (respostaBanco.Read())
                    {
                        Calculo calculo = new Calculo();
                        calculo.Data = Convert.ToDateTime(respostaBanco["data"]);
                        calculo.Ambiente = respostaBanco["ambiente"].ToString();
                        calculo.Operacao = respostaBanco["Operacao"].ToString();
                        calculo.MaterialNecessario = respostaBanco["material_necessario"].ToString();

                        listCalculos.Add(calculo);

                    } 

                    return listCalculos;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante autenticação: " + ex.Message);
            }
        }


        public bool deletarTodosCalculos()
        {
            
            try
            {
                string query = "DELETE FROM historicooperacoes";

                var respostaBanco = databaseService.ExecuteNonQuery(query);

                return respostaBanco > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante o delete: " + ex.Message);
            }
        }


    }
}
