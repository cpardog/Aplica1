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
    public partial class VentanaUser : FormBase
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuario=" + VentanaLogin.Codigo;
            DataSet ds = new DataSet();
            ds = Utilidades.Ejecutar(cmd);
            lblNomUsu.Text= ds.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblAccount.Text= ds.Tables[0].Rows[0]["account"].ToString();
            lblIdUsuario.Text= ds.Tables[0].Rows[0]["Id_usuario"].ToString();

            string url = ds.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox2.Image = Image.FromFile(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConPrin = new ContenedorPrincipal();
            this.Hide();
            ConPrin.Show();
        }
    }
}
