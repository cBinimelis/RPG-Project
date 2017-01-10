using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Project
{
    public partial class Tienda : Form
    {
        SQL sql = new SQL();
        int idItem;
        public Tienda()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            llenaGrid();
        }

        public void llenaGrid()
        {
            sql.llenaGrid(Grid_Items, "select * from Items where id_type = "+Util.getCharacter().getId_type().ToString()+"");
            Grid_Items.Columns[0].Visible = false;
            Grid_Items.Columns[2].Visible = false;
        }

        private void Tienda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getMM().Show();
        }

        private void Grid_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_itemName.Text = Grid_Items.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            lbl_itemPrice.Text = Grid_Items.CurrentRow.Cells[3].EditedFormattedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch { }
        }
    }
}
