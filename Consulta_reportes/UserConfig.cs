using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Data;
using System.Windows.Forms;

namespace Consulta_reportes
{
    public partial class UserConfig : UserControl
    {
        private string printerName;
        public string PrinterName
        {
            get { return printerName; }
        }
        public UserConfig()
        {
            InitializeComponent();
            getSelectedPrinterName();
            Printers.Text = Printers.Items[0].ToString();
            printerName  = Printers.Text;
        }

        private void getSelectedPrinterName()
        {
            foreach(var printer in PrinterSettings.InstalledPrinters)
            {
                Printers.Items.Add(printer);
            }
        }

    }
}
