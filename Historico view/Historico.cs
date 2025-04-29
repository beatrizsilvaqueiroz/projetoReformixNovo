using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix.Historico_view
{
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
            PreencherHistorico();
        }

        private void PreencherHistorico()
        {
            string[,] dados = new string[,]
            {
                { "24/02/2025", "10:30", "Estimador de Tinta" },
                { "27/02/2025", "14:20", "Cálculo de Azulejo" },
                { "30/02/2025", "13:00", "Estimador de Tinta" },
                { "04/03/2025", "11:25", "Cálculo de Azulejo" },
                { "10/03/2025", "12:05", "Estimador de Tinta" },
                { "23/04/2025", "16:40", "Cálculo de Azulejo" },
                { "25/04/2025", "09:35", "Cálculo de Azulejo" }
            };

            labelData1.Text = dados[0, 0];
            labelHora1.Text = dados[0, 1];
            labelOperacao1.Text = dados[0, 2];

            labelData2.Text = dados[1, 0];
            labelHora2.Text = dados[1, 1];
            labelOperacao2.Text = dados[1, 2];

            labelData3.Text = dados[2, 0];
            labelHora3.Text = dados[2, 1];
            labelOperacao3.Text = dados[2, 2];

            labelData4.Text = dados[3, 0];
            labelHora4.Text = dados[3, 1];
            labelOperacao4.Text = dados[3, 2];

            labelData5.Text = dados[4, 0];
            labelHora5.Text = dados[4, 1];
            labelOperacao5.Text = dados[4, 2];

            labelData6.Text = dados[5, 0];
            labelHora6.Text = dados[5, 1];
            labelOperacao6.Text = dados[5, 2];

            labelData7.Text = dados[6, 0];
            labelHora7.Text = dados[6, 1];
            labelOperacao7.Text = dados[6, 2];
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            labelData1.Text = labelHora1.Text = labelOperacao1.Text = "";
            labelData2.Text = labelHora2.Text = labelOperacao2.Text = "";
            labelData3.Text = labelHora3.Text = labelOperacao3.Text = "";
            labelData4.Text = labelHora4.Text = labelOperacao4.Text = "";
            labelData5.Text = labelHora5.Text = labelOperacao5.Text = "";
            labelData6.Text = labelHora6.Text = labelOperacao6.Text = "";
            labelData7.Text = labelHora7.Text = labelOperacao7.Text = "";
        }
    }
}

