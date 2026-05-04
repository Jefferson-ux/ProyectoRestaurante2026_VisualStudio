using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_V_2
{
    public partial class SideBarMenu : Form
    {
        private Button currentbtn;
        private Panel leftBorderbtn;

        public SideBarMenu()
        {
            InitializeComponent();
            hideSubMenu();

            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(8, 51);
        }


        //METODO PARA MOSTRAR SUBMENUS DESPLEGADOS Y ENLAZAR CABECERA--
        private void hideSubMenu()
        {
            panelVentServSubmenu.Visible = false;
            panelRecuHumaSubmenu.Visible = false;
            panelGestSalonSubmenu.Visible = false;
            panelInventarioSubmenu.Visible = false;
        }


        //METODO PARA CENTRALIZAR Y ENLAZAR--
        private void EnlazarCabecera(object sender)
        {
            if (sender is Button btnActivo)
            {
                imgCurrentChildForm.Image = btnActivo.Image;
                if (string.IsNullOrWhiteSpace(btnActivo.Text))
                {
                    lblTituloFormulario.Text = btnActivo.Tag != null ? btnActivo.Tag.ToString() : btnActivo.Text;
                }
                else
                {
                    lblTituloFormulario.Text = btnActivo.Text;
                }
            }
        }


        //METODO PARA ACTIVAR BOTONES Y CAMBIARLOS--
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentbtn = (Button)senderBtn;
                currentbtn.Parent.Controls.Add(leftBorderbtn);
                currentbtn.BackColor = Color.FromArgb(52, 107, 94);
                currentbtn.ForeColor = Color.FromArgb(137, 192, 179);
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderbtn.BackColor = Color.FromArgb(34, 71, 62);
                leftBorderbtn.Location = new Point(0, currentbtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(61, 66, 68); // Color de fondo normal
                currentbtn.ForeColor = Color.FromArgb(79, 161, 141);
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //METODO PARA EL BOTON MENU DESPEGABLE--
        private void CollapseMenu()
        {
            if (this.MenuVertical.Width > 200) // --- COLAPSAR MENÚ ---
            {
                MenuVertical.Width = 100;

                // Recorremos todos los controles del panel lateral
                foreach (Control ctrl in MenuVertical.Controls)
                {
                    // 1. Botones principales (Padres)
                    if (ctrl is Button btn)
                    {
                        ConfigurarBotonColapsado(btn);
                    }

                    // 2. Botones dentro de los submenús (Hijos)
                    if (ctrl is Panel subMenu)
                    {
                        foreach (Button btnHijo in subMenu.Controls.OfType<Button>())
                        {
                            ConfigurarBotonColapsado(btnHijo);
                        }
                    }
                }
            }
            else // --- EXPANDIR MENÚ ---
            {
                MenuVertical.Width = 250;

                foreach (Control ctrl in MenuVertical.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        ConfigurarBotonExpandido(btn);
                    }

                    if (ctrl is Panel subMenu)
                    {
                        foreach (Button btnHijo in subMenu.Controls.OfType<Button>())
                        {
                            ConfigurarBotonExpandido(btnHijo);
                        }
                    }
                }
            }
        }

        // Métodos de apoyo para no repetir código:

        private void ConfigurarBotonColapsado(Button btn)
        {
            btn.Text = ""; // Quitamos el texto
            btn.ImageAlign = ContentAlignment.MiddleCenter; // Centramos la IMAGEN que insertaste
            btn.TextImageRelation = TextImageRelation.Overlay; // Imagen sobre el texto (que no hay)
            btn.Padding = new Padding(0);
        }

        private void ConfigurarBotonExpandido(Button btn)
        {
            btn.Text = "   " + (btn.Tag != null ? btn.Tag.ToString() : "");
            btn.AutoEllipsis = false;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(5, 0, 0, 0);
            btn.UseMnemonic = false;
        }


        //METODO PARA MOSTRAR SUBMENUS DESPLEGADOS--
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        //METODO PARA MOSTRAR SUBMENUS DESPLEGADOS Y ENLAZAR CABECERA--
        private void btnPadre_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == "btnVentServ") showSubMenu(panelVentServSubmenu);
                else if (btn.Name == "btnInventario") showSubMenu(panelInventarioSubmenu);
                else if (btn.Name == "btnGestSalon") showSubMenu(panelGestSalonSubmenu);
                else if (btn.Name == "btnRecuHuma") showSubMenu(panelRecuHumaSubmenu);

                EnlazarCabecera(sender);
            }
        }

        private void btnHijo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(79, 161, 50));
            EnlazarCabecera(sender);
        }


        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO--
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        int LX, LY;
        int SW, SH;

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //METODO PARA ABRIR LOS FORMULARIOS--
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (Formhijo == null) return;
            Form fh = Formhijo as Form;
            if (fh == null || fh == this) return;
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            fh.BringToFront();
        }


        //FIN DE METODOS-----------------------------------------------------------------------------------------------------


        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new ClientesForm());
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new PedidoForm());
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new Empleado());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {

        }

        private void btnPlatosMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new MesaForm());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new ProductosPanel());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentServ_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentServSubmenu);
        }

        private void btnRecuHuma_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRecuHumaSubmenu);
        }

        private void btnGestSalon_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGestSalonSubmenu);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInventarioSubmenu);
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new MesaForm());
        }

        private void btnProvProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new Proveedor_Producto());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new Proveedor());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnDetaPedi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            btnHijo_Click(sender, e);
            AbrirFormEnPanel(new DetalleForm());
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {

        }

        private void SideBarMenu_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null, e);
        }

    }
}
