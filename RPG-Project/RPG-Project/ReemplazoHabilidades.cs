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
    public partial class ReemplazoHabilidades : Form
    {
        SQL sql = new SQL();
        public ReemplazoHabilidades()
        {
            InitializeComponent();
        }

        private void ReemplazoHabilidades_Load(object sender, EventArgs e)
        {
            Settear();
        }

        public void Settear()
        {
            checkAta1.Text = Util.getAta1().getAttack_name();
            checkAta2.Text = Util.getAta2().getAttack_name();
            checkAta3.Text = Util.getAta3().getAttack_name();
            checkAta4.Text = Util.getAta4().getAttack_name();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://s.akk.li/pirate");
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar los ataques seleccionados?", "Luego podrás seleccionar otros",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = 0;
                if (checkAta1.Checked == true)
                {
                    sql.ejecutar("delete from AttackCharacter where id_attack='" + Util.getAta1().getId_attack() + "'");
                    count++;
                }

                if (checkAta2.Checked == true)
                {
                    sql.ejecutar("delete from AttackCharacter where id_attack='" + Util.getAta2().getId_attack() + "'");
                    count++;
                }

                if (checkAta3.Checked == true)
                {
                    sql.ejecutar("delete from AttackCharacter where id_attack='" + Util.getAta3().getId_attack() + "'");
                    count++;
                }

                if (checkAta4.Checked == true)
                {
                    sql.ejecutar("delete from AttackCharacter where id_attack='" + Util.getAta4().getId_attack() + "'");
                    count++;
                }

                MessageBox.Show("Slots liberados: " + count);
                this.Close();
            }
        }

        private void ReemplazoHabilidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Habilidades h = new Habilidades();
            h.Show();
            Guardar();
        }


        public void Guardar()
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
