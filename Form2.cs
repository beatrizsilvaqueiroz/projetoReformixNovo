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

namespace Reformix
{
    public partial class Form2 : Form
    {
        private HistoricoRepositorio historicoRepositorio;
       
        public Form2()
        {
            InitializeComponent();
            historicoRepositorio = new HistoricoRepositorio(new Services.DatabaseService());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Calculo> listCalculos = historicoRepositorio.getAllCalculos();
            listBox1.DataSource = listCalculos;
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = listCalculos;
        }
    }
}
