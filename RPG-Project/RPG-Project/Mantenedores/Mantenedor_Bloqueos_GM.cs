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
    public partial class Mantenedor_Bloqueos_GM : Form
    {
        SQL sql = new SQL();
        int id_bloqueo;
        public Mantenedor_Bloqueos_GM()
        {
            InitializeComponent();
        }

        private void gameMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gameMasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Bloqueos_GM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.vBlocks_GM' Puede moverla o quitarla según sea necesario.
            this.vBlocks_GMTableAdapter.Fill(this.iDataSet1.vBlocks_GM);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.gameMaster' Puede moverla o quitarla según sea necesario.
            this.gameMasterTableAdapter.Fill(this.iDataSet1.gameMaster);

        }

        private void llenado()
        {
            sql.llenaGrid(grillaBloqueos, "select * from vBlocks_GM");
            grillaBloqueos.Columns[0].Visible = false;
            grillaBloqueos.Columns[3].Visible = false;
        }

        private void reset()
        {
            id_bloqueo = 0;
            txt_motivo.Text = "";
            dt_bloqueo.Text = "";
            combo_user.SelectedValue = "";
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_motivo.Equals("") || combo_user.SelectedValue.Equals("") || dt_bloqueo.Value.Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos");
                   
                }else{
                    if (txt_motivo.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("El motivo es demasiado corto");
                    }
                else
                { 

                    if (id_bloqueo.Equals(0))
                    {
                        SqlDataReader dr = sql.consulta("select count(id_block) from Block_GM where id_gameM='" + combo_user.SelectedValue + "' and  blockDate = '" + dt_bloqueo.Value.Date.ToShortDateString() + "'");
                        if (dr.Read())
                        {
                            if (Convert.ToInt32(dr[0]) > 2)
                            {
                                MessageBox.Show("El usuario seleccionado ya se encuentra bloqueado");
                            }
                            else
                            {
                                int bloquear = sql.ejecutar("insert into Block_GM (reason,blockDate,id_gameM) values('" + txt_motivo.Text + "','" + dt_bloqueo.Value.Date.ToShortDateString() + "','" + combo_user.SelectedValue + "')");
                                if (bloquear > 0)
                                {
                                    int cambiar_estado = sql.ejecutar("update gameMaster set id_state= 2 where id_gameM ='" + combo_user.SelectedValue + "'");
                                    if (cambiar_estado > 0)
                                    {
                                        MessageBox.Show("Game Master bloqueado exitosamente", "¿Hacer eso es divertido?");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha podido cambiar el estado del GM");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido bloquear al GM");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea actualizar el bloqueo seleccionado?", "¿Nuevas condiciones?",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlDataReader dr = sql.consulta("select count(id_block) from Block_GM where id_gameM='" + combo_user.SelectedValue + "' and  blockDate = '" + dt_bloqueo.Value.Date.ToShortDateString() + "'");
                            if (dr.Read())
                            {
                                if (Convert.ToInt32(dr[0]) > 2)
                                {
                                    MessageBox.Show("El usuario seleccionado ya se encuentra bloqueado");
                                }
                            }
                            else
                            {
                                int a = sql.ejecutar("update Block_GM set reason ='" + txt_motivo.Text + "','" + dt_bloqueo.Value.Date.ToShortDateString() + "','" + combo_user.SelectedValue + "' where id_block ='" + id_bloqueo + "'");
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
                    int i = sql.ejecutar("delete from Block_GM where id_gameM='" + combo_user.SelectedValue + "'");
                    if (i > 0)
                    {
                        int cambiar_estado = sql.ejecutar("update gameMaster set id_state= 1 where id_gameM ='" + combo_user.SelectedValue + "'");
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

        private void Mantenedor_Bloqueos_GM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }
    }
}
