using System;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Connection;

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
            con.SqlConnect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Sp;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RUTA", path);
            cmd.Parameters.AddWithValue("@NUMARCHIVOS", numArchivos);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
        } 

        private string openFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();


            string initialPath = Environment.GetEnvironmentVariable("userprofile"); //Establece la ruta inicial del cuadro de dialogo
            openFile.InitialDirectory = initialPath + "/Desktop";
            string Path = "";
            try
            {
                openFile.ShowDialog();
                Path = openFile.FileName;
            }
            catch
            {
                MessageBox.Show("No se pudo obtener el archivo");
            }
            
            return Path;
        }

        //ABRIR EL OPENDIALOGFILE Y BUSCAR EL ARCHIVO PARA 
        //QUE LO MUESTRE EN EL TEXTBOX
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = openFile();
            txtPath.Text = path;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            if (pathIsEmpty())
            {
                string path;
                //swapForm(false, true);
                DialogResult clearDataBase = MessageBox.Show("¿Desea limpiar la base de datos?", "Procesando...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (clearDataBase)
                {
                    //EN ESTA PARTE DEL CODIGO HAY MUCHOS BUG!!!!
                    case DialogResult.Yes:
                        txtPath.Clear();
                        DialogResult isThereAnotherFile = MessageBox.Show("¿Quieres importar otro archivo?", "Procesando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                        switch (isThereAnotherFile)
                        {
                            case DialogResult.Yes:
                                userResponse = "2";
                                path = openFile();

                                executeSp(path, userResponse);//EJECUCION DEL SP

                                txtPath.Clear();

                                break;
                            case DialogResult.No:
                                userResponse = "1";

                                executeSp(txtPath.Text, userResponse);//EJECUCION DEL SP

                                txtPath.Clear();
                                
                                break;
                        }

                        break;

                    case DialogResult.No:
                        userResponse = "1";

                        executeSp(txtPath.Text, userResponse);//EJECUCION DEL SP


                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe haber una ruta de archivo","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
