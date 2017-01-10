using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace RPG_Project
{
    public partial class MainMenu : Form
    {
        SQL sql = new SQL();
        public int Vida_Maxima = 250;
        public int Stamina_Maxima = 100;
        public int online = 0;
        System.Windows.Forms.Timer Tiempo = new System.Windows.Forms.Timer();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Tiempo.Interval = 1000;
            Tiempo.Tick += new EventHandler(Tiempo_Tick);
            Settear();
            Actualizar();
            PrepararPvP();
        }

        void Tiempo_Tick(object sender, EventArgs e)
        {
            SqlDataReader comprobar = sql.consulta("SELECT * FROM PvP WHERE id_char2 = " + Util.getCharacter().getId_character() + " AND OnLine = 1 ORDER BY id_pvp DESC");
            if (comprobar.Read())
            {
                Tiempo.Stop();
                if (MessageBox.Show("¿Aceptas el reto que se presenta?", "¡Se encontró un luchador!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlDataReader enemy = sql.consulta("select * from Character where id_character = " + Convert.ToInt32(comprobar[2].ToString()) + "");
                    if (enemy.Read())
                    {
                        int setPvP = sql.ejecutar("UPDATE PvP SET OnLine= 2 WHERE id_char2=" + Util.getCharacter().getId_character() + " AND id_pvp = " + Convert.ToInt32(comprobar[0].ToString()) + "");
                        Enemy EN = new Enemy(Convert.ToInt32(enemy[0].ToString()), enemy[1].ToString(), Convert.ToInt32(enemy[3].ToString()), Convert.ToInt32(enemy[4].ToString()), Convert.ToInt32(enemy[5].ToString()), Convert.ToInt32(enemy[6].ToString()));
                        Util.setEnemy(EN);
                        Util.setMM(this);
                        PvP p = new PvP();
                        p.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al configurar al enemigo");
                    }
                }
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el juego?", "¿Abandonarás la misión?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                int guardado = sql.ejecutar("UPDATE Character set life='" + Vida_Maxima + "', stamina='" + Stamina_Maxima + "', exp= '" + Util.getCharacter().getExp() + "', gold='"
                + Util.getCharacter().getGold() + "' WHERE id_character='" + Util.getCharacter().getId_character() + "'");
                if (guardado > 0)
                {
                    int limpiar = sql.ejecutar("DELETE FROM  PvP WHERE [id_char2] IS NULL AND OnLine = 1");
                    Util.getF1().Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pb_life.Value < 50)
            {
                MessageBox.Show("Te encuentras demasiado debil como para ir a luchar", "Date una vuelta por la posada");
            }
            else
            {
                Aventura a = new Aventura();
                Util.setMM(this);
                a.Show();
                this.Hide();
            }
        }

        private void btn_batalla_Click(object sender, EventArgs e)
        {
            if (pb_life.Value < 50)
            {
                MessageBox.Show("Te encuentras demasiado debil como para ir a luchar", "Date una vuelta por la posada");
            }
            else
            {
                Batalla b = new Batalla();
                Util.setMM(this);
                b.Show();
                this.Hide();
            }
        }

        private void btn_tienda_Click(object sender, EventArgs e)
        {
            Tienda t = new Tienda();
            Util.setMM(this);
            t.Show();
            this.Hide();
        }

        private void btn_habilidades_Click(object sender, EventArgs e)
        {
            Habilidades h = new Habilidades();
            Util.setMM(this);
            h.Show();
            this.Hide();
        }

        private void btn_posada_Click(object sender, EventArgs e)
        {
            Posada p = new Posada();
            Util.setMM(this);
            p.Show();
            this.Hide();
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

        public void Actualizar()
        {
            lbl_nombre.Text = Util.getCharacter().getCharacter_name().ToString();
            lbl_nivel.Text = Util.getCharacter().getLvl().ToString();
            lbl_gold.Text = Util.getCharacter().getGold().ToString();
            pb_life.Value = Util.getCharacter().getLife();
            lbl_life.Text = Util.getCharacter().getLife().ToString();
            pb_stamina.Value = Util.getCharacter().getStamina();
            lbl_stamina.Text = Util.getCharacter().getStamina().ToString();
            pb_exp.Value = Util.getCharacter().getExp();
            lbl_exp.Text = Util.getCharacter().getExp().ToString();
            if (Convert.ToInt32(Util.getCharacter().getId_type().ToString()) == 1)
            {
                pic_personaje.Image = RPG_Project.Properties.Resources.Warrior;
            }
            else if (Convert.ToInt32(Util.getCharacter().getId_type().ToString()) == 2)
            {
                pic_personaje.Image = RPG_Project.Properties.Resources.Archer;
            }
            else if (Convert.ToInt32(Util.getCharacter().getId_type().ToString()) == 3)
            {
                pic_personaje.Image = RPG_Project.Properties.Resources.Mage;
            }
        }

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void MainMenu_Deactivate(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void MainMenu_EnabledChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void PrepararPvP()
        {
            try
            {
                sql.ejecutar("INSERT INTO PvP (id_char1, fecha, OnLine) values (" + Util.getCharacter().getId_character() + ", '" + System.DateTime.Now + "', " + 0 + ")");
            }
            catch (Exception)
            {
                MessageBox.Show("Error en preparar PvP");
            }
        }

        private void btn_pvp_Click(object sender, EventArgs e)
        {
            if (pb_life.Value < 50)
            {
                MessageBox.Show("Te encuentras demasiado debil como para ir a luchar", "Date una vuelta por la posada");
            }
            else
            {
                lanzarPvP();
            }
        }

        public void lanzarPvP()
        {
            SqlDataReader hayAlguien = sql.consulta("select * from PvP where [id_char2] is null AND id_char1 != " + Util.getCharacter().getId_character() + " AND OnLine= 0 order by id_pvp desc");
            if (hayAlguien.Read())
            {
                SqlDataReader enemy = sql.consulta("select * from Character where id_character = " + Convert.ToInt32(hayAlguien[1].ToString()) + "");
                if (enemy.Read())
                {
                    int setPvP = sql.ejecutar("UPDATE PvP SET id_char2=" + Convert.ToInt32(hayAlguien[1].ToString()) + ", OnLine= 1 WHERE id_char1=" + Util.getCharacter().getId_character() + " AND id_pvp = " + Convert.ToInt32(hayAlguien[0].ToString()) + "");
                    if (setPvP > 0)
                    {
                        while (online != 2)
                        {
                            SqlDataReader dr = sql.consulta("SELECT * FROM PvP WHERE id_char1=" + Util.getCharacter().getId_character() + "AND OnLine=2");
                            dr.Read();
                            online = Convert.ToInt32(dr[5]);
                        }
                        Enemy EN = new Enemy(Convert.ToInt32(enemy[0].ToString()), enemy[1].ToString(), Convert.ToInt32(enemy[3].ToString()), Convert.ToInt32(enemy[4].ToString()), Convert.ToInt32(enemy[5].ToString()), Convert.ToInt32(enemy[6].ToString()));
                        Util.setEnemy(EN);
                        Util.setMM(this);
                        PvP p = new PvP();
                        p.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Error al configurar al enemigo");
                }
            }
            else
            {
                MessageBox.Show("No hay personas conectadas", "Empieza a hacer amigos");
                Tiempo.Start();
            }
        }
    }
}
