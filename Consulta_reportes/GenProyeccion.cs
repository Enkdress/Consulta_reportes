using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
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
            string parameter = txtProjection.Text;
            if (parameter != "")
            {
                ConectionDB con = new ConectionDB();
                try
                {
                    con.SqlConnect();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.GetConnection();
                    cmd.CommandText = "sp_aplica_proyeccion";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PROYECCION", parameter);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    txtProjection.Clear();
                    MessageBox.Show("Se ejecutó con exito.", "Ejecución correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    double LabelX = (this.Location.X) * 0.8;
                    double LabelY = (this.Location.Y) * 0.2;
                    Label err = new Label();
                    err.Text = "No se pudo ejecutar correctamente: "+ ex;
                    err.Visible = true;
                    err.ForeColor = Color.Red;
                    err.Location = new Point(Convert.ToInt32(LabelX), Convert.ToInt32(LabelY));
                }


                con.SqlCloseConection();
            }
            else
            {
                MessageBox.Show("El campo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
