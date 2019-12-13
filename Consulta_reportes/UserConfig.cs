using System;
using System.Drawing.Printing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Connection;

namespace Consulta_reportes
{
    public partial class UserConfig : UserControl
    {
        private string printerName;
        private string tblName = "[ENLACE_FE].[dbo].[TBL_CONF_APP]";

        private ConectionDB conn;
        private string selectPrint = "SELECT IMPRESORA FROM TBL_CONF_APP";
        private SqlCommand cmd;

        public UserConfig()
        {
            InitializeComponent();

            showInstalledPrinters();

        }

        private void showInstalledPrinters()
        {
            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                Printers.Items.Add(printer);
            }
        }


        private void insertPrinterName()
        {
            conn = new ConectionDB();
            try
            {

                conn.SqlConnect();
                cmd = new SqlCommand();
                cmd.Connection = conn.GetConnection();
                cmd.CommandText = "DELETE FROM "+tblName+"\nINSERT INTO "+tblName+" VALUES ('" +Printers.Text+"')";
                cmd.CommandType = CommandType.Text;

                var reader = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.SqlCloseConection();
        }



        private void getPrinterName()
        {
            conn = new ConectionDB();
            try
            {

                conn.SqlConnect();
                cmd = new SqlCommand();
                cmd.Connection = conn.GetConnection();
                cmd.CommandText = selectPrint;
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.SqlCloseConection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertPrinterName();
        }
    }
}
