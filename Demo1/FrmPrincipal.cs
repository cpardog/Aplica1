using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Milibreria;

namespace Demo1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaLogin Ventalogin = new VentanaLogin();
            Ventalogin.MdiParent = this;
            Ventalogin.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void conectarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.Ejecutar("Select * from Usuarios where id_usuario=1");
    

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VentanaLogin frmInicio = new VentanaLogin();
            frmInicio.MdiParent = this;
            frmInicio.Show();
        }

    }
}
