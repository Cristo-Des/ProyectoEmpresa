using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmpresa
{
    class OcultarDatos
    {
        public static void ocultar(Control c)
        {
            foreach (Control a in c.Controls)
            {
                if (a is TextBox)
                {
                    a.Text = "";
                    a.Visible = false;
                }
                if (a is Label)
                {
                    a.Text = "";
                    a.Visible = false;
                }
            }
        }
    }
}
