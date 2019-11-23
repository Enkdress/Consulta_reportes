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
    public partial class GenProyeccion : UserControl
    {
        public GenProyeccion()
        {
            InitializeComponent();
        }

        private void btnSendProjection_Click(object sender, EventArgs e)
        {
            if (txtProjection.Text != "")
            {
                RequestDataBase reqDB = new RequestDataBase();
                string cmd = "EXEC sp_aplica_proyeccion " + txtProjection.Text;
                DataSet DS = reqDB.SqlReq(cmd);
            }
            else
            {
                MessageBox.Show("El campo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
