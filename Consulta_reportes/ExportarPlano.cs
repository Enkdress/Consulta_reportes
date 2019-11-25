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

        private string computerName;
        private string folderPath;

        public ExportarPlano()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            ConectionDB con = new ConectionDB();
            computerName = con.GetComputerName();
            try
            {
                con.SqlConnect();//ABRIR CONEXION

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.GetConnection();
                cmd.CommandText = "sp_generar_tmov";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE_DEL_EQUIPO", computerName);
                cmd.Parameters.AddWithValue("@RUTA", folderPath);
                cmd.Parameters.AddWithValue("@NOMBRE", fileName);
                

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                txtFileName.Clear();
                MessageBox.Show("Se ejecutó con exito.", "Ejecución correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la conexion o ejecucion: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.SqlCloseConection();//CERRAR CONEXION
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();

            folderPath = folder.SelectedPath;
        }
    }
}
