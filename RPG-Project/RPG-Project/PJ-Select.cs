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

namespace RPG_Project
{
    public partial class PJ_Select : Form
    {
        SQL sql = new SQL();
        public PJ_Select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos", "Las cosas como son");
                }
                else
                {
                    if (txt_nombre.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("Ingrese un nombre más largo para su personaje", "No hay espacio para tacaños");
                    }
                    else
                    {
                        if (sql.verificar("select * from Character where character_name='" + txt_nombre.Text + "'"))
                        {
                            MessageBox.Show("Ya existe este personaje", "Sin clones");
                        }
                        else
                        {
                            int crear = sql.ejecutar("INSERT INTO Character (character_name, id_type, life, stamina, exp, lvl, gold) values ('" +
                                txt_nombre.Text + "','" + combo_tipo.SelectedValue + "', 250 , 100 , 0 , 1 , 50)");
                            if (crear > 0)
                            {
                                SqlDataReader dr = sql.consulta("SELECT * FROM Character WHERE character_name = '" + txt_nombre.Text + "'");
                                if (dr.Read())
                                {
                                    
                                    int id = Convert.ToInt32(Util.getUsuario().getId_user().ToString());
                                    int asignar = sql.ejecutar("UPDATE User1 set id_character='" + dr[0].ToString() + "' where id_user ='" + id + "'");
                                    if (asignar > 0)
                                    {
                                        MessageBox.Show("¡Tu personaje " + txt_nombre.Text + " ha sido creado!", "Felicitaciones");
                                        Character c = new Character(Convert.ToInt32(dr[0].ToString()), dr[1].ToString(), Convert.ToInt32(dr[2].ToString()), Convert.ToInt32(dr[3].ToString()),
                                                        Convert.ToInt32(dr[4].ToString()), Convert.ToInt32(dr[5].ToString()), Convert.ToInt32(dr[6].ToString()), Convert.ToInt32(dr[7].ToString()));
                                        Util.setCharacter(c);
                                        MainMenu MM = new MainMenu();
                                        MM.Show();
                                        this.Dispose();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al asignar personaje");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error al confirmar nombre");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido crear");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error inesperado", "Comuniquese con su Game master");
            }
        }

        private void characterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.characterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void PJ_Select_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_RPG_ProjectDataSet.Type' Puede moverla o quitarla según sea necesario.
            this.typeTableAdapter2.Fill(this._RPG_ProjectDataSet.Type);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void PJ_Select_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getF1().Close();
        }

        private void combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tipo.SelectedIndex == 0)
            {
                pic_personaje.Image = RPG_Project.Properties.Resources.Warrior;
            }
            else if (combo_tipo.SelectedIndex == 1)
            {
                pic_personaje.Image = RPG_Project.Properties.Resources.Archer;
            }
            else if (combo_tipo.SelectedIndex == 2)
            {
                pic_personaje.Image = RPG_Project.Properties.Resources.Mage;
            }
        }
    }
}
