using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Formularios
{
    public partial class MesaControl : UserControl
    {
        public MesaControl()
        {
            InitializeComponent();

            lblTitulo.Location = new Point(x, y);

        }





        // Atributos
        // Calculamos el centro de X: (Ancho del contenedor / 2) - (Ancho del label / 2)
        int x = (this.Width - lblTitulo.Width) / 2;

        // Mantenemos la Y actual para no moverlo de arriba a abajo
        int y = lblTitulo.Location.Y;


    }
}
