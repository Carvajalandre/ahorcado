using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayStringCarvajal
{
    public partial class frmGuardartext : Form
    {
        public frmGuardartext()
        {
            InitializeComponent();
        }
        string rutaArchivo;
        string nombreArchivo;

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            rutaArchivo = ObtenerRutaArchivo();
            nombreArchivo = Path.GetFileName(rutaArchivo);

            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                try
                {
                    this.txtArchivo.Text = rutaArchivo;
                    this.lblDatos.Text = "Datos Guardados en: " + nombreArchivo;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Guardado cancelado por el usuario.");
            }
        }
        static string ObtenerRutaArchivo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "archivos txt (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar Archivo de Texto";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private void btnGuardartxt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                string textoAguardar = this.txtGuardar.Text;

                if (!string.IsNullOrEmpty(textoAguardar))
                {
                    File.AppendAllText(rutaArchivo, textoAguardar + Environment.NewLine);
                    this.txtGuardado.Text = File.ReadAllText(rutaArchivo);
                }
                else
                {
                    MessageBox.Show("No se ha ingresado ningún texto para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un archivo antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
