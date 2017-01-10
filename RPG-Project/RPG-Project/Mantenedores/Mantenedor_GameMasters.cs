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
    public partial class Mantenedor_GameMasters : Form
    {
        int idGM;
        SQL sql = new SQL();
        string nombre;
        public Mantenedor_GameMasters()
        {
            InitializeComponent();
        }

        private void gameMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gameMasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_GameMasters_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.State' Puede moverla o quitarla según sea necesario.
            this.stateTableAdapter.Fill(this.iDataSet1.State);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.gameMaster' Puede moverla o quitarla según sea necesario.
            this.gameMasterTableAdapter.Fill(this.iDataSet1.gameMaster);
            llenado();
        }

        private void llenado()
        {
            sql.llenaGrid(grillaGM, "select * from vGM");
            grillaGM.Columns[2].Visible = false;
            grillaGM.Columns[4].Visible = false;
        }

        private void Mantenedor_GameMasters_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void grillaGM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idGM = Convert.ToInt32(grillaGM.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_nombre.Text = grillaGM.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaGM.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            txt_pass.Text = grillaGM.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            txt_codigo.Text = grillaGM.CurrentRow.Cells[3].EditedFormattedValue.ToString();
            combo_estado.SelectedValue = grillaGM.CurrentRow.Cells[4].EditedFormattedValue.ToString();
        }

        private void reset()
        {
            idGM = 0;
            txt_nombre.Text = "";
            txt_pass.Text = "";
            txt_codigo.Text = "";
            combo_estado.SelectedValue = 0;
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text.Trim().Equals("") || txt_pass.Text.Trim().Equals("") || txt_codigo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos");
                }
                else
                {
                    if (txt_codigo.Text.Trim().Length != 8 || txt_nombre.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("El codigo tiene que ser de 8 caracteres y/o el usuario mayor a 4  ");
                    }

                    else
                    {
                        if (idGM.Equals(0))
                        {
                            if (sql.verificar("select * from gameMaster where nameGM='" + txt_nombre.Text + "'"))
                            {
                                MessageBox.Show("Ya existe este Administrador", "¿No crees que deberías saberlo?");
                            }
                            else
                            {
                                int r = sql.ejecutar("insert into gameMaster (nameGM, password, GM_code, id_state) values('" + txt_nombre.Text + "','" + txt_pass.Text + "','" + txt_codigo.Text + "','" + combo_estado.SelectedValue + "')");
                                if (r > 0)
                                {
                                    MessageBox.Show("Game Master ingresado correctamente", "Más variedad");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido ingresar el Game Master");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea actualizar el GM seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (nombre.Equals(txt_nombre.Text))
                                {
                                    int a = sql.ejecutar("update gameMaster set nameGM ='" + txt_nombre.Text + "', password='" + txt_pass.Text + "', GM_code='" + txt_codigo.Text + "', id_state='" + combo_estado.SelectedValue + "' where id_state='" + idGM + "'");
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Game Master Actualizado", "Como cambian las cosas...");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el Game Master");
                                    }
                                }
                                else
                                {
                                    if (sql.verificar("select * from gameMaster where nameGM='" + txt_nombre.Text + "'"))
                                    {
                                        MessageBox.Show("Ya existe el Game master deseado", "Sin clones");
                                    }
                                    else
                                    {
                                        int a = sql.ejecutar("update gameMaster set nameGM ='" + txt_nombre.Text + "', password='" + txt_pass.Text + "', GM_code='" + txt_codigo.Text + "', id_state='" + combo_estado.SelectedValue + "' where id_state='" + idGM + "'");
                                        if (a > 0)
                                        {
                                            MessageBox.Show("Game Master Actualizado", "Como cambian las cosas...");
                                            llenado();
                                            reset();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo actualizar el Game Master");
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
            if (idGM.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el Game master?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from gameMaster where id_gameM ='" + idGM + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Game Master suprimido", "Sobre azul");
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

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57)  || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        

        


    }
}
