using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reformix.Tema

{

    public static class GerenciadorTema

    {

        public static void AplicarTema(Form formulario, string tema)

        {

            if (tema == "Escuro")

            {

                formulario.BackColor = Color.FromArgb(30, 30, 30);

                AplicarTemaNosControles(formulario.Controls, Color.White, Color.FromArgb(45, 45, 45));

            }

            else

            {

                formulario.BackColor = SystemColors.Control;

                AplicarTemaNosControles(formulario.Controls, SystemColors.ControlText, SystemColors.Control);

            }

        }

        private static void AplicarTemaNosControles(Control.ControlCollection controles, Color foreColor, Color backColor)

        {

            foreach (Control ctrl in controles)

            {

                if (ctrl is Button)

                {

                    var btn = (Button)ctrl;

                    btn.FlatStyle = FlatStyle.Flat;

                    btn.FlatAppearance.BorderColor = Color.Gray;

                    btn.BackColor = backColor;

                    btn.ForeColor = foreColor;

                }

                else if (ctrl is ComboBox)

                {

                    var combo = (ComboBox)ctrl;

                    combo.BackColor = backColor;

                    combo.ForeColor = foreColor;

                }

                else if (ctrl is Label || ctrl is Panel || ctrl is GroupBox || ctrl is TextBox)

                {

                    ctrl.BackColor = backColor;

                    ctrl.ForeColor = foreColor;

                }

                if (ctrl.HasChildren)

                {

                    AplicarTemaNosControles(ctrl.Controls, foreColor, backColor);

                }

            }

        }

    }

}
