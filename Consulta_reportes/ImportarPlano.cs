using Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consulta_reportes
{
    public partial class ImportarPlano : UserControl
    {

        /*
         * CAMPOS DE CLASE
         */
        private string userResponse;
        private string Sp = "sp_importar_tmov";


        public ImportarPlano()
        {
            InitializeComponent();
        }

        //ME DICE SI EL CAMPO DE TEXTO DEL PATH ESTA VACIO O CON TEXTO
        //LO QUE SIGNIFICA QUE EL USUARIO NO HA SELECCIONADO EL O TODO LO CONTRARIO
        private bool pathIsEmpty()
        {
            if (txtPath.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void executeSp(string path, string numArchivos)
        {
            ConectionDB con = new ConectionDB();
            try
            {
                con.SqlConnect();

                SqlCommand cmd = new SqlCommand();
                //CONFIG OF THE COMMAND
                cmd.Connection = con.GetConnection();
                cmd.CommandText = Sp;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUTA", path);
                cmd.Parameters.AddWithValue("@NUMARCHIVOS", numArchivos);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                MessageBox.Show("Se ejecutó con exito.", "Ejecución correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la conexion o ejecucion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.SqlCloseConection();
        }

        private string pathName()
        {
            OpenFileDialog openFile = new OpenFileDialog();


            string initialPath = Environment.GetEnvironmentVariable("userprofile"); //Establece la ruta inicial del cuadro de dialogo
            openFile.InitialDirectory = initialPath + "/Desktop";
            string Path;


            openFile.ShowDialog();
            Path = openFile.FileName;

            txtPath.Text = Path;

            return Path;
        }

        //ABRIR EL OPENDIALOGFILE Y BUSCAR EL ARCHIVO PARA 
        //QUE LO MUESTRE EN EL TEXTBOX
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = pathName();
            txtPath.Text = path;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            if (pathIsEmpty())
            {
                string path = null;

                DialogResult clearDataBase = MessageBox.Show
                    ("¿Desea limpiar los datos?", "Procesando...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (clearDataBase)
                {
                    case DialogResult.Yes:

                        if(MessageBox.Show
                            ("¿Quieres importar otro archivo?", "Procesando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            path = pathName();
                            if (path != "")
                            {
                                userResponse = "2";
                                executeSp(path, userResponse);//EJECUCION DEL SP
                            }
                            else
                            {
                                //COLOCAR MENSAJE QUE DIGA QUE SELECCIONE UN ARCHIVO
                            }

                            txtPath.Clear();
                        }
                        else
                        {
                            userResponse = "1";
                            executeSp(txtPath.Text, userResponse);//EJECUCION DEL SP

                            txtPath.Clear();
                        }

                        break;

                    case DialogResult.No:
                        userResponse = "2";

                        executeSp(txtPath.Text, userResponse);//EJECUCION DEL SP

                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe haber una ruta de archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
