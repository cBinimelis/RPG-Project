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
    public partial class Mantenedor_Monstruos : Form
    {
        int id_monster;
        SQL sql = new SQL();
        string nombre;
        public Mantenedor_Monstruos()
        {
            InitializeComponent();
        }

        private void monsterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monsterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Monstruos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.Monster' Puede moverla o quitarla según sea necesario.
            this.monsterTableAdapter.Fill(this.iDataSet1.Monster);
            llenado();

        }

        private void llenado()
        {
            sql.llenaGrid(grillaMonster, "select * from Monster");
            grillaMonster.Columns[0].Visible = false;
        }

        private void Mantenedor_Monstruos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void grillaMonster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_monster = Convert.ToInt32(grillaMonster.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_nombre.Text = grillaMonster.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaMonster.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            num_damage.Value = Convert.ToInt32(grillaMonster.CurrentRow.Cells[2].EditedFormattedValue.ToString());
            num_lvl.Value = Convert.ToInt32(grillaMonster.CurrentRow.Cells[3].EditedFormattedValue.ToString());
        }
        public void reset()
        {
            id_monster = 0;
            txt_nombre.Text = "";
            num_damage.Value = 0;
            num_lvl.Value = 0;
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Equals("") || num_damage.Value == 0 || num_lvl.Value == 0)
                {
                    MessageBox.Show("No deben quedar campos vacios");
                }    
                else
                {
                    if (txt_nombre.Text.Length < 2)
                    {
                        MessageBox.Show("El nombre es demasiado corto");
                    }
                    else
                    {
                        if (id_monster.Equals(0))
                        {
                            if (sql.verificar("select * from Monster where monster_name='" + txt_nombre.Text + "'"))
                            {
                                MessageBox.Show("No se puede ingresar dos veces el mismo Monstruo", "¿Si deseas actualizar presiona la celda correspondiente?");
                            }
                            else
                            {
                                int r = sql.ejecutar("insert into Monster (monster_name,monster_power,monster_level) values('" + txt_nombre.Text + "','" + num_damage.Value + "','" + num_lvl.Value + "')");
                                if (r > 0)
                                {
                                    MessageBox.Show("Monstruo ingresado correctamente", "Un gran ecosistema en camino");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido ingresar el monstruo");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea actualizar el monstruo seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (nombre.Equals(txt_nombre.Text))
                                {
                                    int a = sql.ejecutar("update Monster set monster_name ='" + txt_nombre.Text + "', monster_power='"
                                            + num_damage.Value + "', monster_level='" + num_lvl.Value + "'  where id_monster='" + id_monster + "'");
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
                                    if (sql.verificar("select * from Monster where monster_name='" + txt_nombre.Text + "'"))
                                    {
                                        MessageBox.Show("Ya existe un monstruo con ese nombre", "No es bueno copiar");
                                    }
                                    else
                                    {
                                        int a = sql.ejecutar("update Monster set monster_name ='" + txt_nombre.Text + "', monster_power='"
                                            + num_damage.Value + "', monster_level='" + num_lvl.Value + "'  where id_monster='" + id_monster + "'");
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
            if (id_monster.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el monstruo?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from Monster where id_monster='" + id_monster + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Monstruo eliminado", "La vida debe continuar");
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

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Mantenedor_Monstruos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
