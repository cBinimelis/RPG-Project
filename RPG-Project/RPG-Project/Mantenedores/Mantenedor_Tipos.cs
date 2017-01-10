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
    public partial class Mantenedor_Tipos : Form
    {
        int id_tipo;
        SQL sql = new SQL();
        string nombre;
        public Mantenedor_Tipos()
        {
            InitializeComponent();
        }

        private void typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Mantenedor_Tipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.Type' Puede moverla o quitarla según sea necesario.
            this.typeTableAdapter.Fill(this.iDataSet1.Type);
            llenado();
        }

        private void Mantenedor_Tipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void grillaTipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_tipo = Convert.ToInt32(grillaTipo.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_nombre.Text = grillaTipo.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaTipo.CurrentRow.Cells[1].EditedFormattedValue.ToString();
        }

        public void llenado()
        {
            sql.llenaGrid(grillaTipo, "select * from Type");
        }

        public void reset()
        {
            id_tipo = 0;
            txt_nombre.Text = "";
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos");
                }
                else
                {
                    if (txt_nombre.Text.Trim().Length < 2)
                    {
                        MessageBox.Show("El nombre es demasiado corto");
                    }
                    else
                    {
                        if (id_tipo.Equals(0))
                        {
                            if (sql.verificar("select * from Type where type_name='" + txt_nombre.Text + "'"))
                            {
                                MessageBox.Show("Ya existe este tipo", "Sin clones");
                            }
                            else
                            {
                                int r = sql.ejecutar("insert into Type (type_name) values('" + txt_nombre.Text + "')");
                                if (r > 0)
                                {
                                    MessageBox.Show("Tipo ingresado correctamente", "Más variedad");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido ingresar el Tipo");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea actualizar el tipo seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (nombre.Equals(txt_nombre.Text))
                                {
                                    int a = sql.ejecutar("update Type set name ='" + txt_nombre.Text + "' where id_type='" + id_tipo + "'");
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Tipo Actualizado", "Como cambian las cosas...");
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
                                    if (sql.verificar("select * from Type where type_name='" + txt_nombre.Text + "'"))
                                    {
                                        MessageBox.Show("Ya existe el tipo deseado", "Sin clones");
                                    }
                                    else
                                    {
                                        int a = sql.ejecutar("update Type set name ='" + txt_nombre.Text + "' where id_type='" + id_tipo + "'");
                                        if (a > 0)
                                        {
                                            MessageBox.Show("Tipo Actualizado", "Como cambian las cosas...");
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
            if (id_tipo.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el tipo seleccionado?", "¿Ya no sirve?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from Type where id_type='" + id_tipo + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Tipo suprimido", "A seguir con la vida");
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
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
