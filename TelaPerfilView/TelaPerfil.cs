using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix.TelaPerfil
{
    public partial class TelaPerfil : Form
    {
        public TelaPerfil()
        {
            InitializeComponent();
            btnAlterarFoto.Click += btnAlterarFoto_Click;
            btnEditarPerfil.Click += btnEditarPerfil_Click;
        }

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecionar uma foto";
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picFotoPerfil.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            bool emVisualizacao = txtNome.ReadOnly;

            txtNome.ReadOnly = !emVisualizacao;
            txtEmail.ReadOnly = !emVisualizacao;
            mtbTelefone.ReadOnly = !emVisualizacao;

            if (emVisualizacao)
            {
                btnEditarPerfil.Text = "Salvar Perfil";
            }
            else
            {
                btnEditarPerfil.Text = "Editar Perfil";
                MessageBox.Show("Perfil salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
