using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RPG_Project.Mantenedores
{
    public partial class Mantenedor_Logs : Form
    {
        SQL sql=new SQL();
        public Mantenedor_Logs()
        {
            InitializeComponent();
        }

        private void logsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Logs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.Logs' Puede moverla o quitarla según sea necesario.
            this.logsTableAdapter.Fill(this.iDataSet1.Logs);

        }

        private void Mantenedor_Logs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        public void llenado()
        {
            //sql.llenaGrid()
        }

    }
}
