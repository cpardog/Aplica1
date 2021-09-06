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
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }
        public static string Codigo = "";
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string cmd = string.Format("Select * from Usuarios where account='{0}' and password ='{1}'",txtUsuario.Text.Trim(), txtPassword.Text.Trim()) ;
                ds = Milibreria.Utilidades.Ejecutar(cmd);
                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string password  = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                if (txtUsuario.Text.Trim()==cuenta && txtPassword.Text.Trim() == password)
                {

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"])==true)
                    {
                        VentanaAdmin Venad = new VentanaAdmin();
                        this.Hide();
                        Venad.Show();
                    }
                    else
                    {
                        VentanaUser Venusr = new VentanaUser();
                        this.Hide();
                        Venusr.Show();
                    }
                    //MessageBox.Show("Usuario correcto");
                }
               
            }
            catch (Exception ex)
            {

                        MessageBox.Show("Contraseña o usuario incorrecto"+ex.Message);

            }
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
