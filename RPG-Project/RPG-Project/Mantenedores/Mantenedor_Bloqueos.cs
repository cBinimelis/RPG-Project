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
    public partial class Mantenedor_Bloqueos : Form
    {
        SQL sql = new SQL();
        public Mantenedor_Bloqueos()
        {
            InitializeComponent();
        }

        private void blocksNBansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.blocksNBansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Bloqueos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.vBlocks' Puede moverla o quitarla según sea necesario.
            this.vBlocksTableAdapter.Fill(this.iDataSet1.vBlocks);
            llenado();
        }

        private void llenado()
        {
            sql.llenaGrid(grillaBloqueos, "select * from vBlocks");
            grillaBloqueos.Columns[0].Visible = false;
            grillaBloqueos.Columns[3].Visible = false;
            grillaBloqueos.Columns[5].Visible = false;
        }

        private void Mantenedor_Bloqueos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }
    }
}
