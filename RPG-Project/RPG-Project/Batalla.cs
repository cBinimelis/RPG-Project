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
    public partial class Batalla : Form
    {
        //Declaración de variables                                                          //Variables
        SQL sql = new SQL();                                                                //Variables
        int Vida_Maxima = Util.getCharacter().getLife();                                    //Variables
        int Stamina_Maxima = Util.getCharacter().getStamina();                              //Variables
        Random ran_number = new Random();                                                   //Variables    
        int id_npc;                                                                         //Variables
        int vida_npc = 200;                                                                 //Variables
        int lvl_npc;                                                                        //Variables
        int poder_npc;
        int ataque1 = Util.getAta1().getDanio();
        int ataque2 = Util.getAta2().getDanio();
        int ataque3 = Util.getAta3().getDanio();
        int ataque4 = Util.getAta4().getDanio();
        int ataquebasico;

        //Declaración de los Timers                                                         //Variables
        System.Windows.Forms.Timer Tiempo = new System.Windows.Forms.Timer();               //Variables
        System.Windows.Forms.Timer Espera = new System.Windows.Forms.Timer();               //Variables
        public Batalla()
        {
            InitializeComponent();
        }

        private void Batalla_Load(object sender, EventArgs e)
        {
            Cargar_Personaje();
            Cargar_NPC();
            Tiempo.Interval = 1000;
            Espera.Interval = 3000;
            Tiempo.Tick += new EventHandler(Tiempo_Tick);
            Espera.Tick += new EventHandler(ContraAtaque);
            Tiempo.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No te preguntaré si quieres rendirte o no, no hay segundas oportunidades en la batalla", "¡Eres una deshonra para tu familia!");
            this.Close();
        }


        void Tiempo_Tick(object sender, EventArgs e)
        {
            Actualizar();
            Regenerar();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void Cargar_NPC()
        {
            //Asignar un valor al azar al id del monstruo
            id_npc = ran_number.Next(1, 21);


            //Seleccionar el montruo de la base de datos cono el indice al azar 
            SqlDataReader NPC = sql.consulta("Select * from NPC where id_npc='" + id_npc + "'");
            NPC.Read();


            //Configurar el monstruo en la Clase local
            NonPlayableCharacters N = new NonPlayableCharacters(Convert.ToInt32(NPC[0].ToString()), NPC[1].ToString(), Convert.ToInt32(NPC[2].ToString()), Convert.ToInt32(NPC[3].ToString()));
            Util.setNPC(N);


            //Seleccionar el nombre del monstruo en relacion a su id
            lbl_NPC.Text = Util.getNPC().getNombre();

            //Elegir el nivel del Monstruo
            lvl_npc = ran_number.Next(1, (Util.getCharacter().getLvl() + 2));


            //Seleccionar la imagen del monstruo en relación a su id
            switch (id_npc)
            {
                case 1:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Skull;
                    break;
                case 2:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Flora;
                    break;
                case 3:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Big_Mac;
                    break;
                case 4:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Bip_Bup_Bop;
                    break;
                case 5:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Breeeep;
                    break;
                case 6:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Bubbles;
                    break;
                case 7:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Te_Agilaste;
                    break;
                case 8:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Cold_Fire;
                    break;
                case 9:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Dino_Chan;
                    break;
                case 10:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Tengo_Dinero_y_Tu_No;
                    break;
                case 11:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Domo_Kyun;
                    break;
                case 12:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Dragon;
                    break;
                case 13:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Keroro;
                    break;
                case 14:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Manite;
                    break;
                case 15:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Moquitos;
                    break;
                case 16:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Mordisquitos;
                    break;
                case 17:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Fatguy;
                    break;
                case 18:
                    pic_NPC.Image = RPG_Project.Properties.Resources.No_es_Charizard;
                    break;
                case 19:
                    pic_NPC.Image = RPG_Project.Properties.Resources.No_es_Kirby;
                    break;
                case 20:
                    pic_NPC.Image = RPG_Project.Properties.Resources.Vida_Laboral;
                    break;
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

            if (vida_npc < 200)
            {
                vida_npc += 2 * lvl_npc;
            }
            else
            {
                vida_npc = 200;
            }
        }

        void ContraAtaque(object sender, EventArgs e)
        {
            int SioNo = ran_number.Next(1, 101);
            int id_ataqueM = ran_number.Next(1, 7);
            SqlDataReader Ataque = sql.consulta("SELECT * FROM Enemy_Attacks WHERE id_attack='" + id_ataqueM + "'");

            if (SioNo % 2 == 0)
            {
                if (Ataque.Read())
                {
                    poder_npc = Convert.ToInt32(Ataque[2].ToString());
                    lbl_habilidades.Text = Util.getNPC().getNombre() + " ha utilizado " + Ataque[1].ToString(); 
                    Vida_Maxima = Vida_Maxima - poder_npc;
                    Espera.Stop();
                }

            }
            else
            {
                poder_npc = ran_number.Next(10, Util.getNPC().getPoder() * 5);
                lbl_habilidades.Text = Util.getNPC().getNombre() + " ha atacado";
                Vida_Maxima = Vida_Maxima - poder_npc;
                Espera.Stop();
            }
        }

        private void Batalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            int guardado = sql.ejecutar("UPDATE Character set life='" + Vida_Maxima + "', stamina='" + Stamina_Maxima + "', exp= '" + Util.getCharacter().getExp() + "', gold='"
                + Util.getCharacter().getGold() + "', lvl ='"+Util.getCharacter().getLvl()+"' WHERE id_character='" + Util.getCharacter().getId_character() + "'");
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
                    Espera.Stop();
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
                }
            }

            //Se actualizan los datos visuales de la vida y stamina del monstruo
            if (vida_npc > 200)
            {
                vida_npc = 200;
                pb_lifeNPC.Value = 200;
                lbl_vidaNPC.Text = vida_npc.ToString();
            }
            else
            {
                if (vida_npc > 0)
                {
                    pb_lifeNPC.Value = vida_npc;
                    lbl_vidaNPC.Text = vida_npc.ToString();
                }
                else
                {
                    Espera.Stop();
                    Tiempo.Stop();
                    pb_lifeNPC.Value = 0;
                    MessageBox.Show("¡Has Ganado!", "¡Felicidades!");
                    Util.getCharacter().setExp(Util.getCharacter().getExp() + (20 / Util.getCharacter().getLvl()));
                    Util.getCharacter().setGold(Util.getCharacter().getGold() + 10);
                    if (Util.getCharacter().getExp() >= 100)
                    {
                        Util.getCharacter().setExp(Util.getCharacter().getExp() - 100);
                        Util.getCharacter().setLvl(Util.getCharacter().getLvl() + 1);
                    }
                    this.Close();
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
                vida_npc = vida_npc - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque1);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta1().getAttack_name();
                vida_npc = vida_npc - ataque1;
                Stamina_Maxima = Stamina_Maxima - Util.getAta1().getCoste();
            }
            Espera.Start();
            Actualizar();
        }

        private void btn_ataque2_Click(object sender, EventArgs e)
        {
            if (Stamina_Maxima < Util.getAta2().getCoste() || (Stamina_Maxima - Util.getAta2().getCoste()) < 0)
            {
                PoderPorNivel(ataquebasico);
                vida_npc = vida_npc - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque2);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta2().getAttack_name();
                vida_npc = vida_npc - ataque2;
                Stamina_Maxima = Stamina_Maxima - Util.getAta2().getCoste();
            }
            Espera.Start();
            Actualizar();
        }

        private void btn_ataque3_Click(object sender, EventArgs e)
        {
            if (Stamina_Maxima < Util.getAta3().getCoste() || (Stamina_Maxima - Util.getAta3().getCoste()) < 0)
            {
                PoderPorNivel(ataquebasico);
                vida_npc = vida_npc - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque3);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta3().getAttack_name();
                vida_npc = vida_npc - ataque3;
                Stamina_Maxima = Stamina_Maxima - Util.getAta3().getCoste();
            }
            Espera.Start();
            Actualizar();
        }

        private void btn_ataque4_Click(object sender, EventArgs e)
        {
            if (Stamina_Maxima < Util.getAta4().getCoste() || (Stamina_Maxima - Util.getAta4().getCoste()) < 0)
            {
                PoderPorNivel(ataquebasico);
                vida_npc = vida_npc - (10 + ataquebasico);
                lbl_habilidades.Text = "No tienes energía para usar el ataque";
            }
            else
            {
                PoderPorNivel(ataque4);
                lbl_habilidades.Text = "Has utilizado: " + Util.getAta4().getAttack_name();
                vida_npc = vida_npc - ataque4;
                Stamina_Maxima = Stamina_Maxima - Util.getAta4().getCoste();
            }
            Espera.Start();
            Actualizar();
        }

    }
}
