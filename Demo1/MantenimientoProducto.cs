using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milibreria;

namespace Demo1
{
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
            if (Utilidades.ValidarFormulario(this,errorProvider1)==false)
            {
                 try
                            {
                                string cmd = string.Format("EXEC ActualizarArticulos '{0}', '{1}', '{2}'", txtIdPro.Text.Trim(), txtNomPro.Text.Trim(), txtPrecio.Text.Trim());
                                Utilidades.Ejecutar(cmd);
                                MessageBox.Show("Artículo actualizado correctamente!");
                                return true;
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Ocurrio el error:" + ex.Message);
                                return false;
                            }
            }
            else
            {
                return false;
            }
           
        }
        public override void Eliminar()
        {

            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtIdPro.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Artículo Eliminado correctamente!");
                //return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio el error:" + ex.Message);
                //return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           // Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar();
        }

        private void btnGuardar_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtIdPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtNomPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
