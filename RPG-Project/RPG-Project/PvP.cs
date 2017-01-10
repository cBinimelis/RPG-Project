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
    public partial class PvP : Form
    {
        SQL sql = new SQL();
        int Vida_Maxima = Util.getCharacter().getLife();
        int Stamina_Maxima = Util.getCharacter().getStamina();
        int vidaEnemigo = Util.getEnemy().getLife();
        int staminaEnemigo = Util.getEnemy().getStamina();
        Random ran_number = new Random();
        int ataque1 = Util.getAta1().getDanio();
        int ataque2 = Util.getAta2().getDanio();
        int ataque3 = Util.getAta3().getDanio();
        int ataque4 = Util.getAta4().getDanio();
        int ataquebasico;
        System.Windows.Forms.Timer Tiempo = new System.Windows.Forms.Timer();
        public PvP()
        {
            InitializeComponent();
        }
        private void PvP_Load(object sender, EventArgs e)
        {
            Cargar_Personaje();
            Cargar_Enemigo();
            Tiempo.Interval = 1000;
            Tiempo.Tick += new EventHandler(Tiempo_Tick);
            Tiempo.Start();
        }

        private void PvP_FormClosing(object sender, FormClosingEventArgs e)
        {
            int guardado = sql.ejecutar("UPDATE Character set life='" + Vida_Maxima + "', stamina='" + Stamina_Maxima + "', exp= '" + Util.getCharacter().getExp() + "', gold='"
                + Util.getCharacter().getGold() + "', lvl ='" + Util.getCharacter().getLvl() + "' WHERE id_character='" + Util.getCharacter().getId_character() + "'");
            if (guardado > 0)
            {
                SqlDataReader dr = sql.consulta("SELECT * FROM Character WHERE id_character = '" + Util.getUsuario().getId_character() + "'");
                if (dr.Read())
                {
                    Character c = new Character(Convert.ToInt32(dr[0].ToString()), dr[1].ToString(), Convert.ToInt32(dr[2].ToString()), Convert.ToInt32(dr[3].ToString()),
                                                Convert.ToInt32(dr[4].ToString()), Convert.ToInt32(dr[5].ToString()), Convert.ToInt32(dr[6].ToString()), Convert.ToInt32(dr[7].ToString()));
                    Util.setCharacter(c);
                    Util.getMM().Show();
                }
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        void Tiempo_Tick(object sender, EventArgs e)
        {
            Intercambio();
            Actualizar();
            Regenerar();
        }

        public void Intercambio()
        {
            int guardado = sql.ejecutar("UPDATE Character set life='" + Vida_Maxima + "', stamina='" + Stamina_Maxima + "', exp= '" + Util.getCharacter().getExp() + "', gold='"
                + Util.getCharacter().getGold() + "', lvl ='" + Util.getCharacter().getLvl() + "' WHERE id_character='" + Util.getCharacter().getId_character() + "'");
            if (guardado > 0)
            {
                SqlDataReader dr = sql.consulta("SELECT * FROM Character WHERE id_character = '" + Util.getUsuario().getId_character() + "'");
                if (dr.Read())
                {
                    Character c = new Character(Convert.ToInt32(dr[0].ToString()), dr[1].ToString(), Convert.ToInt32(dr[2].ToString()), Convert.ToInt32(dr[3].ToString()),
                                                Convert.ToInt32(dr[4].ToString()), Convert.ToInt32(dr[5].ToString()), Convert.ToInt32(dr[6].ToString()), Convert.ToInt32(dr[7].ToString()));
                    Util.setCharacter(c);
                }
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }

            int guardadoEnemigo = sql.ejecutar("UPDATE Character set life='" + vidaEnemigo + "', stamina='" + staminaEnemigo + "' WHERE id_character='" + Util.getEnemy().getId_character() + "'");
            if (guardadoEnemigo > 0)
            {
                SqlDataReader enemy = sql.consulta("SELECT * FROM Character WHERE id_character = '" + Util.getEnemy().getId_character() + "'");
                if (enemy.Read())
                {
                    Enemy EN = new Enemy(enemy.GetInt32(0), enemy.GetString(1), enemy.GetInt32(3), enemy.GetInt32(4), enemy.GetInt32(5), enemy.GetInt32(6));
                    Util.setEnemy(EN);
                }
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            Vida_Maxima = Util.getCharacter().getLife();
            Stamina_Maxima = Util.getCharacter().getStamina();
            vidaEnemigo = Util.getEnemy().getLife();
            staminaEnemigo = Util.getEnemy().getStamina();

        }
        public void Cargar_Personaje()
        {
            try
            {
                //Asignar imagen según el tipo del personaje del usuario
                if (Util.getCharacter().getId_type() == 1)
                {
                    pic_personaje.Image = RPG_Project.Properties.Resources.Warrior;
                }
                else if (Util.getCharacter().getId_type() == 2)
                {
                    pic_personaje.Image = RPG_Project.Properties.Resources.Archer;
                }
                else if (Util.getCharacter().getId_type() == 3)
                {
                    pic_personaje.Image = RPG_Project.Properties.Resources.Mage;
                }
                //Asignar los nombres a los distintos botones según los ataques seleccionados
                btn_ataque1.Text = Util.getAta1().getAttack_name().ToString();
                btn_ataque2.Text = Util.getAta2().getAttack_name().ToString();
                btn_ataque3.Text = Util.getAta3().getAttack_name().ToString();
                btn_ataque4.Text = Util.getAta4().getAttack_name().ToString();
                lbl_nivel.Text = Util.getCharacter().getLvl().ToString();
                pb_life.Value = Convert.ToInt32(Util.getCharacter().getLife().ToString());
                lbl_life.Text = Util.getCharacter().getLife().ToString();
                pb_stamina.Value = Convert.ToInt32(Util.getCharacter().getStamina().ToString());
                lbl_stamina.Text = Util.getCharacter().getStamina().ToString();
                lbl_user.Text = Util.getCharacter().getCharacter_name().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void Cargar_Enemigo()
        {
            try
            {
                // se declara el nombre del otro player
                lbl_userE.Text = Util.getEnemy().getCharacter_name().ToString();
                // se declara el nvl
                lbl_nvlE.Text = Util.getEnemy().getLvl().ToString();

                if (Util.getEnemy().getId_type() == 1)
                {
                    pic_enemigo.Image = RPG_Project.Properties.Resources.Warrior;
                }
                else if (Util.getEnemy().getId_type() == 2)
                {
                    pic_enemigo.Image = RPG_Project.Properties.Resources.Archer;
                }
                else if (Util.getEnemy().getId_type() == 3)
                {
                    pic_enemigo.Image = RPG_Project.Properties.Resources.Mage;
                }
                pb_lifeE.Value = vidaEnemigo;
                lbl_life.Text = Util.getEnemy().getLife().ToString();
                pb_staminaE.Value = Convert.ToInt32(Util.getEnemy().getStamina().ToString());
                lbl_staminaE.Text = Util.getEnemy().getStamina().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void Regenerar()
        {
            if (Vida_Maxima < 250)
            {
                Vida_Maxima += 3 * Util.getCharacter().getLvl();
            }
            else
            {
                Vida_Maxima = 250;
            }

            if (Stamina_Maxima < 100)
            {
                Stamina_Maxima += 2 * Util.getCharacter().getLvl();
            }
            else
            {
                Stamina_Maxima = 100;
            }

            // vida enemigo
        }

        private void btn_ggIZI_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas abandonar?", "¿Qué pasó... gallina?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Que continúe la batalla...", "¡QUEREMOS SANGRE!");
            }
        }

        public void Actualizar()
        {
            //Se actualizan los datos visuales de la vida y stamina del personaje
            if (Vida_Maxima > 250)
            {
                Vida_Maxima = 250;
                pb_life.Value = Vida_Maxima;
                lbl_life.Text = Vida_Maxima.ToString();
            }
            else
            {
                if (Vida_Maxima > 0)
                {
                    pb_life.Value = Vida_Maxima;
                    lbl_life.Text = Vida_Maxima.ToString();
                }
                else
                {
                    Tiempo.Stop();
                    Vida_Maxima = 0;
                    pb_life.Value = 0;
                    MessageBox.Show("Has perdido...", "Has de seguir entrenando");
                    Util.getCharacter().setExp(Util.getCharacter().getExp() + 5);
                    Util.getCharacter().setGold(Util.getCharacter().getGold() + 1);
                    if (Util.getCharacter().getExp() >= 100)
                    {
                        Util.getCharacter().setExp(Util.getCharacter().getExp() - 100);
                        Util.getCharacter().setLvl(Util.getCharacter().getLvl() + 1);
                    }
                    this.Close();
                }

            }
            if (Stamina_Maxima > 100)
            {
                Stamina_Maxima = 100;
                pb_stamina.Value = 100;
                lbl_stamina.Text = Stamina_Maxima.ToString();
            }
            else
            {
                if (Stamina_Maxima > 0)
                {
                    pb_stamina.Value = Stamina_Maxima;
                    lbl_stamina.Text = Stamina_Maxima.ToString();
                }
                else
                {
                    Stamina_Maxima = 0;
                    pb_stamina.Value = 0;
                    lbl_stamina.Text = Stamina_Maxima.ToString();
                }
            }
            // vida enemigo
            if (vidaEnemigo > 250)
            {
                vidaEnemigo = 250;
                pb_lifeE.Value = vidaEnemigo;
                lbl_lifeE.Text = vidaEnemigo.ToString();
            }
            else
            {
                if (vidaEnemigo > 0)
                {
                    pb_lifeE.Value = vidaEnemigo;
                    lbl_lifeE.Text = vidaEnemigo.ToString();
                }
                else
                {
                    Tiempo.Stop();
                    vidaEnemigo = 0;
                    pb_life.Value = 0;
                    MessageBox.Show("Has ganado...", "Has de seguir entrenando no te confies");
                    this.Close();
                }
            }
            // stamina enemigo
            if (staminaEnemigo > 100)
            {
                staminaEnemigo = 100;
                pb_staminaE.Value = 100;
                lbl_staminaE.Text = staminaEnemigo.ToString();
            }
            else
            {
                if (staminaEnemigo > 0)
                {
                    pb_staminaE.Value = staminaEnemigo;
                    lbl_staminaE.Text = staminaEnemigo.ToString();
                }
                else
                {
                    Stamina_Maxima = 0;
                    pb_staminaE.Value = 0;
                }
            }
        }

        public void PoderPorNivel(int ataque)
        {
            switch (Util.getCharacter().getLvl())
            {
                case 1:
                    ataque += 1;
                    break;
                case 2:
                    ataque += 5;
                    break;
                case 3:
                    ataque += 10;
                    break;
                case 4:
                    ataque += 15;
                    break;
                case 5:
                    ataque += 20;
                    break;
                case 6:
                    ataque += 25;
                    break;
                case 7:
                    ataque += 30;
                    break;
                case 8:
                    ataque += 35;
                    break;
                case 9:
                    ataque += 40;
                    break;
                case 10:
                    ataque += 45;
                    break;
                case 11:
                    ataque += 50;
                    break;
                case 12:
                    ataque += 55;
                    break;
                case 13:
                    ataque += 60;
                    break;
                case 14:
                    ataque += 65;
                    break;
                case 15:
                    ataque += 70;
                    break;
                case 16:
                    ataque += 75;
                    break;
                case 17:
                    ataque += 80;
                    break;
                case 18:
                    ataque += 85;
                    break;
                case 19:
                    ataque += 90;
                    break;
                case 20:
                    ataque += 100;
                    break;
            }
        }

        private void btn_ataque1_Click(object sender, EventArgs e)
        {
            if (Stamina_Maxima < Util.getAta1().getCoste() || (Stamina_Maxima - Util.getAta1().getCoste()) < 0)
            {
                PoderPorNivel(ataquebasico);
                vidaEnemigo = vidaEnemigo - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque1);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta1().getAttack_name();
                vidaEnemigo = vidaEnemigo - ataque1;
                Stamina_Maxima = Stamina_Maxima - Util.getAta1().getCoste();
            }
            Intercambio();
            Actualizar();
        }

        private void btn_ataque2_Click(object sender, EventArgs e)
        {
            if (Stamina_Maxima < Util.getAta2().getCoste() || (Stamina_Maxima - Util.getAta2().getCoste()) < 0)
            {
                PoderPorNivel(ataquebasico);
                vidaEnemigo = vidaEnemigo - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque2);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta2().getAttack_name();
                vidaEnemigo = vidaEnemigo - ataque2;
                Stamina_Maxima = Stamina_Maxima - Util.getAta2().getCoste();
            }
            Intercambio();
            Actualizar();
        }

        private void btn_ataque3_Click(object sender, EventArgs e)
        {
            if (Stamina_Maxima < Util.getAta3().getCoste() || (Stamina_Maxima - Util.getAta3().getCoste()) < 0)
            {
                PoderPorNivel(ataquebasico);
                vidaEnemigo = vidaEnemigo - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque3);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta3().getAttack_name();
                vidaEnemigo = vidaEnemigo - ataque3;
                Stamina_Maxima = Stamina_Maxima - Util.getAta3().getCoste();
            }
            Intercambio();
            Actualizar();
        }

        private void btn_ataque4_Click(object sender, EventArgs e)
        {
            if (Stamina_Maxima < Util.getAta4().getCoste() || (Stamina_Maxima - Util.getAta4().getCoste()) < 0)
            {
                PoderPorNivel(ataquebasico);
                vidaEnemigo = vidaEnemigo - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque4);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta4().getAttack_name();
                vidaEnemigo = vidaEnemigo - ataque4;
                Stamina_Maxima = Stamina_Maxima - Util.getAta4().getCoste();
            }
            Intercambio();
            Actualizar();
        }

    }
}






