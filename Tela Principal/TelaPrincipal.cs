using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.Cálculo_Azulejo;
using Reformix.Estimador_de_Tinta;
using Reformix.Historico_view;
using Reformix.Login;
using Reformix.Services;

namespace Reformix.Tela_Principal
    {
        public partial class TelaPrincipal : Form
        {
            public TelaPrincipal()
            {
                InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;

            }

            private void TelaPrincipal_Load(object sender, EventArgs e)
            {
            
                    }
        
            private void CloseApp(object sender, FormClosingEventArgs e)
            {
            Application.ExitThread();
            }

            private void BtnCalculoAzulejo_Click(object sender, EventArgs e)
            {
                var formAzulejo = new CalculoAzulejo();
                formAzulejo.ShowDialog();
            }

            private void BtnEstimadorTinta_Click(object sender, EventArgs e)
            {
                var formTinta = new EstimadorTinta();
                formTinta.ShowDialog();
            }

            private void BtnHistoricoCalculo_Click(object sender, EventArgs e)
            {
                Historico historico = new Historico();
            historico.ShowDialog();
            }

           

            private void BtnLogin_Click(object sender, EventArgs e)
            {
                MessageBox.Show("A tela de login ainda está em desenvolvimento.", "Login");
            }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin(this);
            telaLogin.ShowDialog();
        }

        private void TelaPrincipal_Load_1(object sender, EventArgs e)
        {
            btnLogin.Visible = false;
            nameLogado.Visible = false;

            if (SessaoUsuarioLogado._usuarioLogado == null)
            {
                btnHistoricoCalculo.Visible = false;
                btnLogin.Visible = true;

            }
        }

        public void ShowButtonHistorico()
        {
            btnHistoricoCalculo.Visible = true;
            btnLogin.Visible = false;
            nameLogado.Text = SessaoUsuarioLogado._usuarioLogado.Nome;
            nameLogado.Visible = true;

        }
    }
    }
