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
    public partial class Mantenedor_Estados : Form
    {
        int id_estado;
        SQL sql = new SQL();
        string nombre;
        public Mantenedor_Estados()
        {
            InitializeComponent();
        }

        private void stateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);
            
        }

        private void Mantenedor_Estados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.State' Puede moverla o quitarla según sea necesario.
            this.stateTableAdapter.Fill(this.iDataSet1.State);
            llenado();
        }

        private void llenado()
        {
            sql.llenaGrid(grillaEstado, "select * from State");
        }

        private void Mantenedor_Estados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void grillaEstado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_estado = Convert.ToInt32(grillaEstado.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_estado.Text = grillaEstado.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaEstado.CurrentRow.Cells[1].EditedFormattedValue.ToString();
        }

        public void reset()
        {
            id_estado = 0;
            txt_estado.Text = "";
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_estado.Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos");
                }
                else
                {
                    if (txt_estado.Text.Trim().Length < 4)
                    {
                        MessageBox.Show("El nombre del estado debe ser más claro");
                    }
                    else
                    {
                        if (id_estado.Equals(0))
                        {
                            if (sql.verificar("select * from State where name='" + txt_estado.Text + "'"))
                            {
                                MessageBox.Show("Ya existe este estado", "¿Probaste con el estado Avatar?");
                            }
                            else
                            {
                                int r = sql.ejecutar("insert into State (name) values('" + txt_estado.Text + "')");
                                if (r > 0)
                                {
                                    MessageBox.Show("Estado ingresado correctamente", "Más variedad");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido ingresar el estado");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea actualizar el estado seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (nombre.Equals(txt_estado.Text))
                                {
                                    int a = sql.ejecutar("update State set name ='" + txt_estado.Text + "' where id_state='" + id_estado + "'");
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Estado Actualizado", "Como cambian las cosas...");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el estado");
                                    }
                                }
                                else
                                {
                                    if (sql.verificar("select * from State where name='" + txt_estado.Text + "'"))
                                    {
                                        MessageBox.Show("Ya existe el estado deseado", "Sin clones");
                                    }
                                    else
                                    {
                                        int a = sql.ejecutar("update State set name ='" + txt_estado.Text + "' where id_state='" + id_estado + "'");
                                        if (a > 0)
                                        {
                                            MessageBox.Show("Estado Actualizado", "Como cambian las cosas...");
                                            llenado();
                                            reset();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo actualizar el estado");
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
            if (id_estado.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el estado?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from State where id_state='" + id_estado + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Estado suprimido", "La vida debe continuar");
                        llenado();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada");
                }
            }
        }

        private void txt_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
