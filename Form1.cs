﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reformix.Services;

namespace Reformix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            // Abre a tela principal
            Reformix.Tela_Principal.TelaPrincipal telaPrincipal = new Reformix.Tela_Principal.TelaPrincipal();
            telaPrincipal.Show();

            // Esconde a tela de boas-vindas
            this.Hide();
        }
    }
}
