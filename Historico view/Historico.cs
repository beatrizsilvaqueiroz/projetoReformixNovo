using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.Models;
using Reformix.Repositorio;

namespace Reformix.Historico_view
{
    public partial class Historico : Form
    {
        private HistoricoRepositorio historicoRepositorio;
        public Historico()
        {
            InitializeComponent();
            historicoRepositorio = new HistoricoRepositorio(new Services.DatabaseService());
        }

        private void PreencherHistorico()
        {
           

           
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Historico_Load(object sender, EventArgs e)
        {
           

            List<Calculo> listCalculos = historicoRepositorio.getAllCalculos();
            dataGridView1.DataSource = listCalculos;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimparHistorico_Click_1(object sender, EventArgs e)
        {
          DialogResult  resultado =  MessageBox.Show("Deseja apagar todos os cálculos?", "Deletar Cálculos", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                historicoRepositorio.deletarTodosCalculos();
                dataGridView1.DataSource = null;

            }
            else {

                return;
            
            }
            
            

            

        }
    }
}

