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
    public partial class FormProductoLibre : Form
    {
        public string NombreProducto;
        public float Precio;
        public int Cantidad;
        public FormProductoLibre()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxNombreProducto.Text) ||
                !float.TryParse(nUDPrecioProducto.Text, out float precio))
            {
                MessageBox.Show("Por favor, ingresá valores válidos.");
                return;
            }

            NombreProducto = tboxNombreProducto.Text.Trim();
            Precio = precio;
            Cantidad = 1;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
