using BLL;
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
    public partial class FormBorrarProductos : Form
    {
        public FormBorrarProductos()
        {
            InitializeComponent();
        }
        ProductoBLL productoBLL = new ProductoBLL();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool hacerBackup = cBoxBackUp.Checked;
            string direccionBackUp = tBoxDireccionBackUp.Text.Trim();
            if (hacerBackup && string.IsNullOrWhiteSpace(direccionBackUp))
            {
                MessageBox.Show(
                    "Por favor, seleccione una dirección para guardar el backup.",
                    "Dirección inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (hacerBackup)
            {
                productoBLL.ExportarExcel(tBoxDireccionBackUp.Text);
            }
            try
            {
                int eliminados = productoBLL.EliminarTodosLosProductos(cBoxBackUp.Checked, tBoxDireccionBackUp.Text);

                MessageBox.Show(
                    $"Se eliminaron {eliminados} productos.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar los productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Seleccione la carpeta donde se guardará el backup";
                dlg.ShowNewFolderButton = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tBoxDireccionBackUp.Text = dlg.SelectedPath;

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
