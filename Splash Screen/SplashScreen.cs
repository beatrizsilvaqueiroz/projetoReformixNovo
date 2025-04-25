using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix.Splash_Screen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.Load += SplashScreen_Load; // adiciona o evento Load
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Inicia o Timer assim que a SplashScreen carregar
            splashTimer.Interval = 5000; // 5 segundos
            splashTimer.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();

            // Abre a tela de boas-vindas (Form1)
            Reformix.Form1 telaBoasVindas = new Reformix.Form1();
            telaBoasVindas.Show();

            // Fecha a splash
            this.Hide();
        }
    }
}
