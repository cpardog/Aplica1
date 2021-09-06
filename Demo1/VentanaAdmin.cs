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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuario=" + VentanaLogin.Codigo;
            DataSet ds = new DataSet();
            ds = Utilidades.Ejecutar(cmd);
            lblNomadmin.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsadmin.Text = ds.Tables[0].Rows[0]["account"].ToString();
            lblCodigo.Text = ds.Tables[0].Rows[0]["Id_usuario"].ToString();

            string url = ds.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox2.Image = Image.FromFile(url);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConPrin = new ContenedorPrincipal();
            this.Hide();
            ConPrin.Show();
        }
    }
}
