using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Connection;

namespace Consulta_reportes
{
    public partial class ExportarPlano : UserControl
    {

        public ExportarPlano()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            ConectionDB con = new ConectionDB();
            con.SqlConnect();//ABRIR CONEXION

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_generar_tmov";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PLANO", fileName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            con.SqlCloseConection();//CERRAR CONEXION
        }
    }
}
