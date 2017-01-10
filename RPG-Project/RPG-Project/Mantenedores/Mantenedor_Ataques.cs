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
    public partial class Mantenedor_Ataques : Form
    {
        SQL sql = new SQL();
        int id_ataque;
        string nombre;

        public Mantenedor_Ataques()
        {
            InitializeComponent();
        }

        private void attackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attackBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Ataques_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_RPG_ProjectDataSet.Type' Puede moverla o quitarla según sea necesario.
            this.typeTableAdapter.Fill(this._RPG_ProjectDataSet.Type);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.vAtaques' Puede moverla o quitarla según sea necesario.
            this.vAtaquesTableAdapter.Fill(this.iDataSet1.vAtaques);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.Attack' Puede moverla o quitarla según sea necesario.
            this.attackTableAdapter.Fill(this.iDataSet1.Attack);
            llenado();
        }

        public void llenado()
        {
            sql.llenaGrid(grillaAtaques, "select * from vAtaques");
            grillaAtaques.Columns[0].Visible = false;
            grillaAtaques.Columns[2].Visible = false;
        }

        private void Mantenedor_Ataques_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void grillaAtaques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ataque = Convert.ToInt32(grillaAtaques.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_atName.Text = grillaAtaques.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaAtaques.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            combo_tipo.SelectedValue = grillaAtaques.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            num_costo.Value = Convert.ToInt32(grillaAtaques.CurrentRow.Cells[4].EditedFormattedValue.ToString());
            num_danio.Value = Convert.ToInt32(grillaAtaques.CurrentRow.Cells[5].EditedFormattedValue.ToString());
        }

        public void reset()
        {
            id_ataque = 0;
            txt_atName.Text = "";
            combo_tipo.SelectedValue = 0;
            num_costo.Value = 0;
            num_danio.Value = 0;
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_atName.Text.Trim().Equals("") || combo_tipo.SelectedValue.Equals("") || num_costo.Value == 0 || num_danio.Value == 0)
                {
                    MessageBox.Show("No deben quedar campos vacíos");
                }
                else
                {
                    if (txt_atName.Text.Trim().Length < 4)
                    {
                        MessageBox.Show("El nombre es demasiado corto");
                    }
                    else
                    {
                        if (id_ataque.Equals(0))
                        {
                            if (sql.verificar("select * from Attack where attack_name='" + txt_atName.Text + "'"))
                            {
                                MessageBox.Show("Ya existe un ataque con ese nombre");
                            }
                            else
                            {
                                int r = sql.ejecutar("insert into Attack (attack_name,id_type,coste,daño) values('" + txt_atName.Text + "','" + combo_tipo.SelectedValue + "','" + num_costo.Value + "','" + num_danio.Value + "')");
                                if (r > 0)
                                {
                                    MessageBox.Show("Ataque ingresado correctamente", "Nueva técnica *-*");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido ingresar la técnica");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea actualizar el ataque seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (nombre.Equals(txt_atName.Text))
                                {
                                    int a = sql.ejecutar("update Attack set attack_name ='" + txt_atName.Text + "',id_type='" + combo_tipo.SelectedValue + "', coste ='" + num_costo.Value + "',daño ='" + num_danio.Value + "' where id_attack='" + id_ataque + "'");
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Ataque Actualizado", "Bien hecho insecto!");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el ataque");
                                    }
                                }
                                else
                                {
                                    if (sql.verificar("select * from Attack where attack_name='" + txt_atName.Text + "'"))
                                    {
                                        MessageBox.Show("Ya existe ese ataque", "Sin clones");
                                    }
                                    else
                                    {
                                        int a = sql.ejecutar("update Attack set attack_name ='" + txt_atName.Text + "',id_type='" + combo_tipo.SelectedValue + "', coste ='" + num_costo.Value + "',daño ='" + num_danio.Value + "' where id_attack='" + id_ataque + "'");
                                        if (a > 0)
                                        {
                                            MessageBox.Show("Ataque Actualizado", "Bien hecho insecto!");
                                            llenado();
                                            reset();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo actualizar el ataque");
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id_ataque.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el ataque?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from Attack where id_attack='" + id_ataque + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Ataque suprimido", "A seguir entrenando");
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

        private void txt_atName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8)|| (e.KeyChar==32))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
