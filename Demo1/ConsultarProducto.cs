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
    public partial class ConsultarProducto : Consultas
    {
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDGV("Articulo").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text) == false)
            {
                try
                {
                    string cmd = "Select * from Articulo where Nom_pro like '%" + txtBuscar.Text.Trim() + "%'";
                    DataSet ds;
                    ds = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error :" + ex.Message);
                }

            }
        }
    }
}
