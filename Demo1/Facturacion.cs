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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            try
            {
             string cmd = "select * from Usuarios where id_usuario=" + VentanaLogin.Codigo;
             DataSet ds;
             ds = Utilidades.Ejecutar(cmd);
             lblLeAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);

            }

           

        }
    }
}
