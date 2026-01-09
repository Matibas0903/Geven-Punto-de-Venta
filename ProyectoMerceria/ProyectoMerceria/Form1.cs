using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMerceria
{
    public partial class Form1 : Form
    {
        UC_CrearVenta crearVenta;
        UC_AgregarProductos agregarProducto;
        UC_EditarProducto editarProducto;
        UC_VentasDiarias ventasDiarias;
        UC_DetalleDeVenta detalleDeVenta;
        int idProducto;
        DateTime Fecha = DateTime.Now; 
        public Form1()
        {
            crearVenta = new UC_CrearVenta();
            agregarProducto = new UC_AgregarProductos();
            editarProducto = new UC_EditarProducto(idProducto);
            ventasDiarias = new UC_VentasDiarias();
            detalleDeVenta = new UC_DetalleDeVenta(ventasDiarias);
            InitializeComponent();

            CentrarContenidoEnPanelLateral();

        }

        //Controles y Eventos
        private void btnVentasDiarias_Click(object sender, EventArgs e)
        {
            MostrarVentasDiarias();
        }
        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            MostrarCrearVenta();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            MostrarAgregarProducto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CentrarContenidoEnPanelLateral();
        }

        private void panelContenedor_Resize(object sender, EventArgs e)
        {
            CentrarContenidoEnPanel();
        }

        private void panelLateral_Resize(object sender, EventArgs e)
        {

            CentrarContenidoEnPanelLateral();
        }

        //Metodos logicos
        private void CentrarContenidoEnPanel()
        {

            if (panelContenedor.Controls.Count == 0)
                return; // No hay controles, no hacemos nada
            Control contenido = panelContenedor.Controls[0];

          
            // Solo continúa si ya tiene tamaño
            if (contenido.Width == 0 || contenido.Height == 0) return;

            contenido.Left = (panelContenedor.Width - contenido.Width) / 2;
            contenido.Top = (panelContenedor.Height - contenido.Height) / 2;
        }

        private void CentrarContenidoEnPanelLateral()
        {
            if (panelLateral.Controls.Count == 0)
                return;

            int espacioEntreBotones = 30;

            var controlesOrdenados = panelLateral.Controls.Cast<Control>()
                                       .OrderBy(c => c.TabIndex)
                                       .ToList();

            int totalHeight = controlesOrdenados.Sum(c => c.Height + c.Margin.Top + c.Margin.Bottom + espacioEntreBotones);

            int startY = (panelLateral.Height - totalHeight) / 2;

            int currentY = startY;

            foreach (var c in controlesOrdenados)
            {
                c.Left = (panelLateral.Width - c.Width) / 2;
                c.Top = currentY;
                currentY += c.Height + c.Margin.Top + c.Margin.Bottom + espacioEntreBotones;
            }
        }


        private void CargarUserControl(UserControl control)
        {
            panelContenedor.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.None;  
            panelContenedor.Controls.Add(control);      // Agrega el nuevo
            CentrarContenidoEnPanel();

            panelContenedor.Resize -= (s, e) => CentrarContenidoEnPanel();
            panelContenedor.Resize += (s, e) => CentrarContenidoEnPanel();
        }
        public void MostrarDetalleVentas(int idVenta) 
        {
            CargarUserControl(detalleDeVenta);
            detalleDeVenta.LlenarListaDetalles(idVenta);
        }
        public void MostrarVentasDiarias() 
        {
            CargarUserControl(ventasDiarias);
            ventasDiarias.LlenarListaVentas(Fecha);
            ventasDiarias.ResetearFecha();
        }

        public void MostrarCrearVenta() 
        {
            CargarUserControl(crearVenta);
            crearVenta.LlenarListaProductos();
        }
        public void MostrarAgregarProducto()
        {
            CargarUserControl(agregarProducto);
            agregarProducto.LlenarListaProductos();
        }
        public void MostrarEditarProducto(int idProducto)
        {
            CargarUserControl(editarProducto);
            editarProducto.CargarProducto(idProducto);
        }

       
    }
}
