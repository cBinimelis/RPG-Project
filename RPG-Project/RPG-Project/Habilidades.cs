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
    public partial class Habilidades : Form
    {
        SQL sql = new SQL();
        int id_char = Convert.ToInt32(Util.getCharacter().getId_character().ToString());
        int id_ataque;
        public Habilidades()
        {
            InitializeComponent();
        }

        private void attackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attackBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iDataSet1);

        }

        private void Habilidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iDataSet1.Attack' Puede moverla o quitarla según sea necesario.
            this.attackTableAdapter.Fill(this.iDataSet1.Attack);
            llenado();
        }

        public void llenado()
        {
            sql.llenaGrid(grillaAtaques, "select * from vAtaques where id_type = " + Util.getCharacter().getId_type().ToString() + "");
            grillaAtaques.Columns[0].Visible = false;
            grillaAtaques.Columns[2].Visible = false;
        }

        private void Habilidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getMM().Show();
            Settear();
        }

        private void grillaAtaques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ataque = Convert.ToInt32(grillaAtaques.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            lbl_ataque.Text = grillaAtaques.CurrentRow.Cells[1].EditedFormattedValue.ToString();     
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {
            SqlDataReader Ataque = sql.consulta("SELECT COUNT(id_AC) FROM AttackCharacter WHERE id_character='" + Util.getCharacter().getId_character().ToString() + "'");
            if (Ataque.Read())
            {
                if (Convert.ToInt32(Ataque[0]) < 4)
                {
                    if (sql.verificar("select * from AttackCharacter where id_attack ='" + id_ataque + "'"))
                    {
                        MessageBox.Show("Ya posees este ataque", "Sin repetir el plato");
                    }
                    else
                    {
                        int ingreso = sql.ejecutar("INSERT INTO AttackCharacter values('" + id_char + "','" + id_ataque + "')");
                        if (ingreso > 0)
                        {
                            MessageBox.Show("Ataque agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Primero selecciona un ataque","Error al asignar el ataque");
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Has alcanzado el tope de ataques permitidos ¿Deseas reemplazar alguno existente?",
                        "Sólo se permite elegir 4 ataques", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ReemplazoHabilidades rh = new ReemplazoHabilidades();
                        rh.Show();
                        this.Hide();
                        Settear();
                    }
                }
            }
        }

        public void Settear()
        {
            try
            {
                SqlDataReader Ataque = sql.consulta("SELECT id_attack FROM AttackCharacter WHERE id_character='" + Util.getCharacter().getId_character().ToString() + "'");


                //1111111111111111111
                //Configurar Ataque 1
                //1111111111111111111
                if (Ataque.Read())
                {
                    SqlDataReader A1 = sql.consulta("SELECT * FROM Attack where id_attack='" + Ataque[0].ToString() + "'");
                    if (A1.Read())
                    {
                        Ataque1 At1 = new Ataque1(Convert.ToInt32(A1[0].ToString()), Convert.ToInt32(A1[1].ToString()), A1[2].ToString(), Convert.ToInt32(A1[3].ToString()), Convert.ToInt32(A1[4].ToString()));
                        Util.setAtaque1(At1);
                    }
                    else
                    {
                        Ataque1 At1 = new Ataque1(0, 0, "Golpe Normal", 0, 10);
                        Util.setAtaque1(At1);
                    }
                }
                else
                {
                    Ataque1 At1 = new Ataque1(0, 0, "Golpe Normal", 0, 10);
                    Util.setAtaque1(At1);
                }


                //2222222222222222222
                //Configurar Ataque 2
                //2222222222222222222
                if (Ataque.Read())
                {
                    SqlDataReader A2 = sql.consulta("SELECT * FROM Attack where id_attack='" + Ataque[0].ToString() + "'");
                    if (A2.Read())
                    {
                        Ataque2 At2 = new Ataque2(Convert.ToInt32(A2[0].ToString()), Convert.ToInt32(A2[1].ToString()), A2[2].ToString(), Convert.ToInt32(A2[3].ToString()), Convert.ToInt32(A2[4].ToString()));
                        Util.setAtaque2(At2);
                    }
                    else
                    {
                        Ataque2 At2 = new Ataque2(0, 0, "Golpe Normal", 0, 10);
                        Util.setAtaque2(At2);
                    }
                }
                else
                {
                    Ataque2 At2 = new Ataque2(0, 0, "Golpe Normal", 0, 10);
                    Util.setAtaque2(At2);
                }

                //3333333333333333333
                //Configurar Ataque 3
                //3333333333333333333
                if (Ataque.Read())
                {
                    SqlDataReader A3 = sql.consulta("SELECT * FROM Attack where id_attack='" + Ataque[0].ToString() + "'");
                    if (A3.Read())
                    {
                        Ataque3 At3 = new Ataque3(Convert.ToInt32(A3[0].ToString()), Convert.ToInt32(A3[1].ToString()), A3[2].ToString(), Convert.ToInt32(A3[3].ToString()), Convert.ToInt32(A3[4].ToString()));
                        Util.setAtaque3(At3);
                    }
                    else
                    {
                        Ataque3 At3 = new Ataque3(0, 0, "Golpe Normal", 0, 10);
                        Util.setAtaque3(At3);
                    }
                }
                else
                {
                    Ataque3 At3 = new Ataque3(0, 0, "Golpe Normal", 0, 10);
                    Util.setAtaque3(At3);
                }

                //4444444444444444444
                //Configurar Ataque 4
                //4444444444444444444
                if (Ataque.Read())
                {
                    SqlDataReader A4 = sql.consulta("SELECT * FROM Attack where id_attack='" + Ataque[0].ToString() + "'");
                    if (A4.Read())
                    {
                        Ataque4 At4 = new Ataque4(Convert.ToInt32(A4[0].ToString()), Convert.ToInt32(A4[1].ToString()), A4[2].ToString(), Convert.ToInt32(A4[3].ToString()), Convert.ToInt32(A4[4].ToString()));
                        Util.setAtaque4(At4);
                    }
                    else
                    {
                        Ataque4 At4 = new Ataque4(0, 0, "Golpe Normal", 0, 10);
                        Util.setAtaque4(At4);
                    }
                }
                else
                {
                    Ataque4 At4 = new Ataque4(0, 0, "Golpe Normal", 0, 10);
                    Util.setAtaque4(At4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
