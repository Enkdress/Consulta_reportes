using System;
using System.Collections;
using System.IO;
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
        private string stringToPrint;
        private PrintDocument documentToPrint;

        private ConectionDB conection;
        private SqlCommand cmd;


        public Report()
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

                conection.SqlCloseConection();
            }
            catch (Exception err)
            {
                MessageBox.Show("No se pudo crear el archivo de texto con los datos del comprobante");
            }
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
                MessageBox.Show("No se pudo generar el reporte");
            }

            //step 2 Crear el archivo
            createPrintFile();

            //step 3 LEER EL ARCHIVO E IMPRIMIRLO
            FileStream fileStream = new FileStream(path + fileName+".txt", FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            stringToPrint = reader.ReadToEnd();
            documentToPrint = new PrintDocument();
            var printers = PrinterSettings.InstalledPrinters;

            foreach (var printer in printers)
            {
                if(printer.ToString() == "Generic")
                {
                    documentToPrint.PrinterSettings.PrinterName = "Generic";
                }
            }

            documentToPrint.DefaultPageSettings.Margins.Left = 50;
            documentToPrint.PrintPage += new PrintPageEventHandler(printPage);
            documentToPrint.Print();
            fileStream.Close();
            reader.Close();

            //step 4 LO ELIMINA DESPUES DE IMPRIMIRLO
            File.Delete(path + fileName);
        }

        private void printPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
            Graphics graphics = e.Graphics;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);
        }

    }
}
