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
    public partial class Mantenedor_Bloqueos_User : Form
    {
        SQL sql = new SQL();
        int id_bloqueo;

        public Mantenedor_Bloqueos_User()
        {
            InitializeComponent();
        }

        private void blocksNBansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Bloqueos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.vBlocks_User' Puede moverla o quitarla según sea necesario.
            this.vBlocks_UserTableAdapter.Fill(this.iDataSet1.vBlocks_User);
            this.user1TableAdapter.Fill(this.iDataSet1.User1);
            dt_bloqueo.MaxDate = System.DateTime.Now;
            llenado();
        }

        private void llenado()
        {
            sql.llenaGrid(grillaBloqueos, "select * from vBlocks_User");
            grillaBloqueos.Columns[0].Visible = false;
            grillaBloqueos.Columns[3].Visible = false;
        }

        private void reset()
        {
            id_bloqueo =0;
            txt_motivo.Text = "";
            dt_bloqueo.Text = "";
            combo_user.SelectedValue = 0;
        }

        private void Mantenedor_Bloqueos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_motivo.Equals("") || combo_user.SelectedValue.Equals("") || dt_bloqueo.Value.Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos");
                }else {
                    if (txt_motivo.Text.Trim().Length < 4)
                    {
                        MessageBox.Show("El motivo es demasiado corto");
                    }
                
                else
                {
                    if (id_bloqueo.Equals(0))
                    {
                        SqlDataReader dr = sql.consulta("select count(id_block) from Block_User where id_user='" + combo_user.SelectedValue + "' and  blockDate = '" + dt_bloqueo.Value.Date.ToShortDateString() + "'");
                        if (dr.Read())
                        {
                            if (Convert.ToInt32(dr[0]) > 2)
                            {
                                MessageBox.Show("El usuario seleccionado ya se encuentra bloqueado");
                            }
                            else
                            {
                                int bloquear = sql.ejecutar("insert into Block_user (reason,blockDate,id_user) values('" + txt_motivo.Text + "','" + dt_bloqueo.Value.Date.ToShortDateString() + "','" + combo_user.SelectedValue + "')");
                                if (bloquear > 0)
                                {
                                    int cambiar_estado = sql.ejecutar("update User1 set id_state= 2 where id_user ='" + combo_user.SelectedValue + "'");
                                    if (cambiar_estado > 0)
                                    {
                                        MessageBox.Show("Usuario bloqueado exitosamente", "¿Hacer eso es divertido?");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha podido cambiar el estado del usuario");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido bloquear al usuario");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea actualizar el bloqueo seleccionado?", "¿Nuevas condiciones?",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlDataReader dr = sql.consulta("select count(id_block) from Block_User where id_user='" + combo_user.SelectedValue + "' and  blockDate = '" + dt_bloqueo.Value.Date.ToShortDateString() + "'");
                            if (dr.Read())
                            {
                                if (Convert.ToInt32(dr[0]) > 2)
                                {
                                    MessageBox.Show("El usuario seleccionado ya se encuentra bloqueado");
                                }
                            }
                            else
                            {
                                int a = sql.ejecutar("update Block_User set reason ='" + txt_motivo.Text + "','" + dt_bloqueo.Value.Date.ToShortDateString() + "','" + combo_user.SelectedValue + "' where id_block ='" + id_bloqueo + "'");
                                if (a > 0)
                                {
                                    MessageBox.Show("Bloqueo Actualizado", "Bien hecho insecto!");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo actualizar el bloqueo");
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
            if (id_bloqueo.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el bloqueo?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from Block_User where id_user='" + combo_user.SelectedValue + "'");
                    if (i > 0)
                    {
                        int cambiar_estado = sql.ejecutar("update User1 set id_state= 1 where id_user ='" + combo_user.SelectedValue + "'");
                        if (cambiar_estado > 0)
                        {
                            MessageBox.Show("Bloqueo suprimido", "A seguir jugando");
                            llenado();
                            reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
            }
        }

        private void grillaBloqueos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_bloqueo = Convert.ToInt32(grillaBloqueos.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_motivo.Text = grillaBloqueos.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            dt_bloqueo.Text = grillaBloqueos.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            combo_user.SelectedValue = grillaBloqueos.CurrentRow.Cells[3].EditedFormattedValue.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txt_motivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}
