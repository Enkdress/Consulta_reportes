using System;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Data;
using System.Windows.Forms;
using Connection;
using System.Data.SqlClient;
using System.Drawing;

namespace Consulta_reportes
{
    public partial class Report : UserControl
    {

        private string path = "C:/Users/Public/Documents/";
        private string fileName = "Tickt";
        private string machineName = Environment.GetEnvironmentVariable("computername");

        private ConectionDB conection;
        private SqlCommand cmd;


        public Report()
        {
            InitializeComponent();
            initialDatePicker.Focus();
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
                MessageBox.Show("No se pudo crear el archivo de texto con los datos del comprobante, "+ err.Message);
            }

            conection.SqlCloseConection();
        }

        private void printTicket(object sender, EventArgs e)
        {

            //step 0 obtención de los datos

            //****DATOS DE LA FECHA**** 
            int year = initialDatePicker.Value.Year;
            int month = initialDatePicker.Value.Month;
            int day = initialDatePicker.Value.Day;
            string ticketDate = year.ToString() + month.ToString() + day.ToString(); //DATOS CONCATENADOS PARA EL PARAMETRO

            //****CONSECUTIVO DEL COMPROBANTE****
            string idTicket = txtIdTicket.Text;

            //****HORA DEL CIERRE DEL COMPROBANTE****
            string closeTime = cmbCloseTime.Text;

            //step 1 ejecutar sp del informe
            conection = new ConectionDB();
            conection.SqlConnect();

            try
            {
                cmd = new SqlCommand();
                cmd.Connection = conection.GetConnection();
                cmd.CommandText = "SP_IMP_COMP_DIARIO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NUMLIBRO", idTicket);
                cmd.Parameters.AddWithValue("@FECHACOMPDIARIO", ticketDate);
                cmd.Parameters.AddWithValue("@FECHACIERREDIARIO", ticketDate);
                cmd.Parameters.AddWithValue("@HORACIERREDIARIO", closeTime);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                conection.SqlCloseConection();

            }
            catch (Exception err)
            {
                MessageBox.Show("No se pudo generar el reporte: "+ err.Message);
            }

            //step 2 Crear el archivo
            createPrintFile();



            //step 3 LEER EL ARCHIVO E IMPRIMIRLO
            string batName = "imprimir.bat";
            try
            {
                string script = @"print /D:LPT1  C:\Users\Public\Documents\Tickt.txt";

                File.WriteAllText(path+batName, script);
                
                Process.Start(path + batName).WaitForExit();
            }
            catch(Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //step 4 LO ELIMINA DESPUES DE IMPRIMIRLO
            File.Delete(path + fileName + ".txt");
            File.Delete(path + batName);
        }


    }
}
