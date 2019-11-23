using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_reportes
{
    public partial class ExportarPlano : UserControl
    {

        public ExportarPlano()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            string sql = "EXEC sp_generar_tmov " + fileName;
            RequestDataBase reqDB = new RequestDataBase();
            DataSet result = reqDB.SqlReq(sql);

            try
            {
                txtQueryResult.Text = result.Tables[0].Rows[0][0].ToString();
                txtQueryResult.Visible = true;
            }
            catch
            {
                txtQueryResult.Text = "No se pudo obtener la ruta";
                txtQueryResult.Visible = true;
            }
            
        }
    }
}
