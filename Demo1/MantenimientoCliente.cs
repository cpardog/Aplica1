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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {
        }

        public override Boolean Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                 try
                            {
                                string cmd = string.Format("EXEC ActualizarClientes '{0}', '{1}', '{2}'", txtIdCliente.Text.Trim(), txtNomCliente.Text.Trim(), txtApeCliente.Text.Trim());
                                Utilidades.Ejecutar(cmd);
                                MessageBox.Show("Cliente Actualizado correctamente!");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar();
           
        }
        public override void Eliminar()
        {
             try
                        {
                            string cmd = string.Format("EXEC EliminarClientes '{0}'", txtIdCliente.Text.Trim());
                            Utilidades.Ejecutar(cmd);
                            MessageBox.Show("Cliente eliminado correctamente!");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Ocurrio el error:" + ex.Message);
                        }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           // Eliminar();
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtNomCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtApeCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
