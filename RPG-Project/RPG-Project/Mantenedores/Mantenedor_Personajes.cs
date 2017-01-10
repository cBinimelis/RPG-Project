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
    public partial class Mantenedor_Personajes : Form
    {
        int id_char;
        SQL sql = new SQL();
        string nombre;
        public Mantenedor_Personajes()
        {
            InitializeComponent();
        }

        private void Mantenedor_Personajes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.User1' Puede moverla o quitarla según sea necesario.
            this.user1TableAdapter.Fill(this.iDataSet1.User1);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.Type' Puede moverla o quitarla según sea necesario.
            this.typeTableAdapter.Fill(this.iDataSet1.Type);
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.vChars' Puede moverla o quitarla según sea necesario.
            this.vCharsTableAdapter.Fill(this.iDataSet1.vChars);
            llenado();
        }

        public void llenado()
        {
            sql.llenaGrid(grillaChars, "select * from vChars");
            grillaChars.Columns[0].Visible = false;
            grillaChars.Columns[2].Visible = false;
            grillaChars.Columns[4].Visible = false;
        }

        public void reset()
        {
            id_char = 0;
            txt_name.Text = "";
            combo_tipo.SelectedValue = 0;
            num_vida.Value = 0;
            num_energia.Value = 0;
            num_exp.Value = 0;
            num_lvl.Value = 0;
            num_dinero.Value = 0;
        }

        private void Mantenedor_Personajes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getGmm().Show();
        }

        private void grillaChars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_char = Convert.ToInt32(grillaChars.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_name.Text = grillaChars.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = grillaChars.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            combo_tipo.SelectedValue = grillaChars.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            num_vida.Value = Convert.ToInt32(grillaChars.CurrentRow.Cells[4].EditedFormattedValue.ToString());
            num_energia.Value = Convert.ToInt32(grillaChars.CurrentRow.Cells[5].EditedFormattedValue.ToString());
            num_exp.Value = Convert.ToInt32(grillaChars.CurrentRow.Cells[6].EditedFormattedValue.ToString());
            num_lvl.Value = Convert.ToInt32(grillaChars.CurrentRow.Cells[7].EditedFormattedValue.ToString());
            num_dinero.Value = Convert.ToInt32(grillaChars.CurrentRow.Cells[8].EditedFormattedValue.ToString());
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text.Trim().Equals("") || combo_tipo.SelectedValue.Equals("") || num_vida.Value == 0 || num_energia.Value == 0 || num_lvl.Value == 0)
                {
                    MessageBox.Show("No deben quedar campos vacíos");

                }
                else
                {
                    if (txt_name.Text.Trim().Length < 4)
                    {
                        MessageBox.Show("El nombre es demasiado corto");
                    }

                    else
                    {
                        if (id_char.Equals(0))
                        {
                            if (sql.verificar("select * from Character where character_name='" + txt_name.Text + "'"))
                            {
                                MessageBox.Show("Ya existe este personaje", "Sin clones");
                            }
                            else
                            {
                                int r = sql.ejecutar("insert into Character (character_name, id_type, life, stamina, exp, lvl, gold) values('" + txt_name.Text + "','" +
                                    combo_tipo.SelectedValue + "','" + num_vida.Value + "','" + num_energia.Value + "','" + num_exp.Value + "','" +
                                    num_lvl.Value + "','" + num_dinero.Value + "')");
                                if (r > 0)
                                {
                                    MessageBox.Show("Personaje ingresado correctamente", "Más variedad");
                                    llenado();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido ingresar el personaje");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea actualizar el usuario seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (nombre.Equals(txt_name.Text))
                                {
                                    int a = sql.ejecutar("update Character set character_name ='" + txt_name.Text + "', id_type= '" + combo_tipo.SelectedValue +
                                            "', life='" + num_vida.Value + "', stamina='" + num_energia.Value + "', exp='" + num_exp.Value + "', lvl='" + num_lvl.Value + "',gold='" + num_dinero.Value + "' where id_character = '" + id_char + "'");
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Personaje Actualizado", "Como cambian las cosas...");
                                        llenado();
                                        reset();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el personaje");
                                    }
                                }
                                else
                                {
                                    if (sql.verificar("select * from Character where character_name='" + txt_name.Text + "'"))
                                    {
                                        MessageBox.Show("Ya existe el usuario deseado", "Sin clones");
                                    }
                                    else
                                    {
                                        int a = sql.ejecutar("update Character set character_name ='" + txt_name.Text + "', id_type= '" + combo_tipo.SelectedValue +
                                            "', life='" + num_vida.Value + "', stamina='" + num_energia.Value + "', exp='" + num_exp.Value + "', lvl='" + num_lvl.Value + "',gold='" + num_dinero.Value + "' where id_character = '" + id_char + "'");
                                        if (a > 0)
                                        {
                                            MessageBox.Show("Personaje Actualizado", "Como cambian las cosas...");
                                            llenado();
                                            reset();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo actualizar el personaje");
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
            if (id_char.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el Personaje?", "¿Ya no te gusta ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("delete from Character where id_character='" + id_char + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Personaje suprimido", "La vida debe continuar");
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

        private void num_energia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        }
    }


    
