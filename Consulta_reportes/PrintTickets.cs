using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Connection;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;

namespace Consulta_reportes
{
    public partial class PrintTickets : UserControl
    {
        private string cmdText = "SP_EXEC_IMP_FACTURAS";
        private string path = "C:/Users/Public/Documents/";
        private string fileName = "Tickt";
        private string machineName = Environment.GetEnvironmentVariable("computername");

        private ConectionDB conection;
        private SqlCommand cmd;


        public PrintTickets()
        {
            InitializeComponent();
        }


        private void createPrintFile()
        {
            conection = new ConectionDB();
            conection.SqlConnect();

            try
            {
                cmd = new SqlCommand();
                cmd.Connection = conection.GetConnection();
                cmd.CommandText = "sp_generar_txt_impresion";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ruta", path);
                cmd.Parameters.AddWithValue("@nombre", fileName);
                cmd.Parameters.AddWithValue("@nombre_del_equipo", machineName);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


            }
            catch (Exception err)
            {
                MessageBox.Show("No se pudo crear el archivo de texto con los datos de la factura, " + err.Message);
            }

            conection.SqlCloseConection();
        }


        private void printTicket(object sender, EventArgs e)
        {

            //step 0 obtención de los datos
            string initConsec = txtInitConsec.Text;

            string finConsec = txtFinConcec.Text;

            string actualTime;
                if(txtTime.Text == "")
                {
                    actualTime = new DateTime().Hour + ":" + new DateTime().Minute + ":" + new DateTime().Second;
                }
                else
                {
                    actualTime = txtTime.Text;
                }


            string docType = txtDoc.Text;
            //step 1 ejecutar sp de la factura
            conection = new ConectionDB();
            conection.SqlConnect();

            try
            {
                cmd = new SqlCommand();
                cmd.Connection = conection.GetConnection();
                cmd.CommandText = cmdText;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TIPODOC_FACT", docType);
                cmd.Parameters.AddWithValue("@NUMERO_INI", initConsec);
                cmd.Parameters.AddWithValue("@NUMERO_FIN", finConsec);
                cmd.Parameters.AddWithValue("@HORA", actualTime);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                conection.SqlCloseConection();

            }
            catch (Exception err)
            {
                MessageBox.Show("No se pudo generar la factura: " + err.Message);
            }

            //step 2 Crear el archivo
            createPrintFile();

            //step 3 LEER EL ARCHIVO E IMPRIMIRLO
            string batName = "imprimir.bat";
            try
            {
                string script = @"print /D:LPT1 C:\Users\Public\Documents\Tickt.txt";

                File.WriteAllText(path + batName, script);

                Process.Start(path + batName).WaitForExit();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //step 4 LO ELIMINA DESPUES DE IMPRIMIRLO
            File.Delete(path + fileName + ".txt");
            File.Delete(path + batName);
        }

    }
}
