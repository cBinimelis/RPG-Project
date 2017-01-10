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
    public partial class Mantenedor_Usuario : Form
    {
        int id_user;
        SQL sql = new SQL();
        string nombre;
        public Mantenedor_Usuario()
        {
            InitializeComponent();
        }

        private void user1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.State' Puede moverla o quitarla según sea necesario.
            this.stateTableAdapter.Fill(this.iDataSet1.State);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.user2' Puede moverla o quitarla según sea necesario.
            this.user2TableAdapter.Fill(this.iDataSet1.user2);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.User1' Puede moverla o quitarla según sea necesario.
            this.user1TableAdapter.Fill(this.iDataSet1.User1);
            llenado();
        }

        public void llenado()
        {
            sql.llenaGrid(grillaUsuarios, "select * from user2");
            grillaUsuarios.Columns[3].Visible = false;
            grillaUsuarios.Columns[2].Visible = false;
        }

        public void reset()
        {
            id_user = 0;
            txt_username.Text = "";
            txt_pass.Text = "";
            combo_estado.SelectedValue = 0;
        }

        private void Mantenedor_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void grillaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_user = Convert.ToInt32(grillaUsuarios.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_username.Text = grillaUsuarios.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaUsuarios.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            txt_pass.Text = grillaUsuarios.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            combo_estado.SelectedValue = grillaUsuarios.CurrentRow.Cells[3].EditedFormattedValue.ToString();
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Equals("") || txt_pass.Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos");
                }
                else
                {
                    if (txt_username.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("El nombre es demasiado corto");
                    }
                    if (id_user.Equals(0))
                    {
                        if (sql.verificar("select * from User1 where nameGM='" + txt_username.Text + "'"))
                        {
                            MessageBox.Show("Ya existe este Usuario", "Sin clones");
                        }
                        else
                        {
                            int r = sql.ejecutar("insert into User1 (user_name, password, id_state) values('" + txt_username.Text + "','" + txt_pass.Text + "','" + combo_estado.SelectedValue + "')");
                            if (r > 0)
                            {
                                MessageBox.Show("Usuario ingresado correctamente", "Más variedad");
                                llenado();
                                reset();
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido ingresar el Usuario");
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea actualizar el usuario seleccionado?", "Chan chan chan",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (nombre.Equals(txt_username.Text))
                            {
                                int a = sql.ejecutar("update User1 set user_name ='" + txt_username.Text + "', password='" + txt_pass.Text + "',id_state='" + combo_estado.SelectedValue + "' where id_state='" + id_user + "'");
                                if (a > 0)
                                {
                                    MessageBox.Show("Usuario Actualizado", "Como cambian las cosas...");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo actualizar el usuario");
                                }
                            }
                            else
                            {
                                if (sql.verificar("select * from User1 where user_name='" + txt_username.Text + "'"))
                                {
                                    MessageBox.Show("Ya existe el usuario deseado", "Sin clones");
                                }
                                else
                                {
                                    int a = sql.ejecutar("update User1 set user_name ='" + txt_username.Text + "', password='" + txt_pass.Text + "',id_state='" + combo_estado.SelectedValue + "' where id_state='" + id_user + "'");
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Usuario Actualizado", "Como cambian las cosas...");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el usuario");
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
            if (id_user.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from User1 where id_user='" + id_user + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Usuario suprimido", "A seguir con la vida");
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

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
