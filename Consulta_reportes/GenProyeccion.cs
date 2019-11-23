using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Connection;

namespace Consulta_reportes
{
    public partial class GenProyeccion : UserControl
    {
        public GenProyeccion()
        {
            InitializeComponent();
        }

        private void btnSendProjection_Click(object sender, EventArgs e)
        {
            if (txtProjection.Text != "")
            {
                ConectionDB con = new ConectionDB();
                con.SqlConnect();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_aplica_proyeccion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PROYECCION", txtProjection.Text);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                con.SqlCloseConection();
            }
            else
            {
                MessageBox.Show("El campo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
