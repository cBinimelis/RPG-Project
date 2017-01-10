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
    public partial class Mantenedor_NPCs : Form
    {
        SQL sql = new SQL();
        int id_npc;
        string nombre;
        public Mantenedor_NPCs()
        {
            InitializeComponent();
        }

        private void nPCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nPCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_NPCs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet11.NPC' Puede moverla o quitarla según sea necesario.
            this.nPCTableAdapter.Fill(this.iDataSet11.NPC);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.NPC' Puede moverla o quitarla según sea necesario.
            this.nPCTableAdapter.Fill(this.iDataSet1.NPC);
            llenado();
        }

        private void llenado()
        {
            sql.llenaGrid(grillaNPC, "select * from NPC");
            grillaNPC.Columns[0].Visible = false;
        }

        private void Mantenedor_NPCs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }


        private void grillaNPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_npc = Convert.ToInt32(grillaNPC.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_nombre.Text = grillaNPC.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaNPC.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            num_damage.Value = Convert.ToInt32(grillaNPC.CurrentRow.Cells[2].EditedFormattedValue.ToString());
            num_lvl.Value = Convert.ToInt32(grillaNPC.CurrentRow.Cells[3].EditedFormattedValue.ToString());
        }

        public void reset()
        {
            id_npc = 0;
            txt_nombre.Text = "";
            num_damage.Value = 0;
            num_lvl.Value = 0;
        }


        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Equals("") || num_damage.Value ==0 || num_lvl.Value ==0)
                {
                    MessageBox.Show("No deben quedar campos vacios");
                }
                else
                {
                    if (txt_nombre.Text.Trim().Length < 2)
                    {
                        MessageBox.Show("El nombre es demasiado corto");
                    }
                    else
                    {
                        if (id_npc.Equals(0))
                        {
                            if (sql.verificar("select * from NPC where npc_name='" + txt_nombre.Text + "'"))
                            {
                                MessageBox.Show("No se puede ingresar dos veces el mismo NPC", "¿Si deseas actualizar presiona la celda correspondiente?");
                            }
                            else
                            {
                                int r = sql.ejecutar("insert into NPC (npc_name, npc_power, npc_level) values('" + txt_nombre.Text + "','" + num_damage.Value + "','" + num_lvl.Value + "')");
                                if (r > 0)
                                {
                                    MessageBox.Show("NPC ingresado correctamente", "Un gran ejercito en camino");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido ingresar el NPC");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea actualizar el NPC seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (nombre.Equals(txt_nombre.Text))
                                {
                                    int a = sql.ejecutar("update NPC set npc_name ='" + txt_nombre.Text + "', npc_power='"
                                            + num_damage.Value + "', npc_level='" + num_lvl.Value + "'  where id_npc='" + id_npc + "'");
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Monstruo actualizado", "A metamorfosearse");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el Monstruo");
                                    }
                                }
                                else
                                {
                                    if (sql.verificar("select * from NPC where npc_name='" + txt_nombre.Text + "'"))
                                    {
                                        MessageBox.Show("Ya existe un NPC con ese nombre", "No es bueno copiar");
                                    }
                                    else
                                    {
                                        int a = sql.ejecutar("update NPC set npc_name ='" + txt_nombre.Text + "', npc_power='"
                                            + num_damage.Value + "', npc_level='" + num_lvl.Value + "'  where id_npc='" + id_npc + "'");
                                        if (a > 0)
                                        {
                                            MessageBox.Show("Monstruo actualizado", "A metamorfosearse");
                                            llenado();
                                            reset();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo actualizar el Monstruo");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id_npc.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el NPC?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from NPC where id_npc='" + id_npc + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("NPC eliminado", "La vida debe continuar");
                        llenado();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ZZ5LpwO-An4");
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }


    }
}
