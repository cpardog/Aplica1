using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Milibreria
{
    public class Utilidades
    {
        public  static DataSet  Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source = localhost; Initial Catalog = contrato; Integrated Security = True");
            Con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);
            DP.Fill(DS);Con.Close();
            return DS;
        }


        public static Boolean ValidarFormulario(Control  Objeto, ErrorProvider errorProvider)
        {
            Boolean HayErrores = false;
            foreach (Control item in Objeto.Controls)
            {
                if (item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)item;
                    if (Obj.Validar==true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            errorProvider.SetError(Obj, "No puede estar vacío el campo");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        errorProvider.SetError(Obj, "");
                    }
                }
            }
            return HayErrores;
        }
    }
}
