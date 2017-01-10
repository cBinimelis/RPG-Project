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
    public partial class Form1 : Form
    {
        SQL sql = new SQL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text.Trim().Equals("") || txt_pass.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No deben quedar campos incompletos", "No se me apure");
                }
                else
                {
                    if (sql.verificar("select * from gameMaster where nameGM = '" + txt_user.Text + "'") == true)
                    {
                        MessageBox.Show("Esta no es tu ventana de acceso", "Psss... Doble click en el logo");
                    }
                    else
                    {
                        SqlDataReader lector = sql.consulta("select * from User1 where user_name = '" + txt_user.Text + "'");
                        if (lector.Read() == false)
                        {
                            MessageBox.Show("No se encuentra el usuario seleccionado", "¿Probó con registrarse?");
                        }
                        else
                        {
                            if (lector[3].Equals(txt_pass.Text) == false)
                            {
                                sql.ejecutar("insert into Block_User (reason, blockDate, id_user) values('Contraseña erronea','" + System.DateTime.Now + "'," + lector[0].ToString() + ")");
                                SqlDataReader dr = sql.consulta("select count(id_block) from Block_User where id_user='" + lector[0].ToString() + "'");
                                if (dr.Read())
                                {
                                    if (Convert.ToInt32(dr[0]) > 2)
                                    {
                                        sql.ejecutar("update User1 set id_state = 2 where id_user='" + lector[0].ToString() + "'");
                                        MessageBox.Show("No hay espacio para los olvidadizos en la guerra", "Has sido desterrado");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Contraseña incorrecta, al tercer error se bloqueará su cuenta", dr[0].ToString() + " veces mal ingresado");
                                    }
                                }
                            }
                            else
                            {
                                if (lector[2] == DBNull.Value)
                                {
                                    Usuario u = new Usuario(Convert.ToInt32(lector[0].ToString()), lector[1].ToString(), 1, lector[3].ToString(), Convert.ToInt32(lector[4].ToString()));
                                    MessageBox.Show("Primero debes crear tu personaje", "Bienvenido a Pixel Adventure");
                                    PJ_Select pj = new PJ_Select();
                                    Util.setF1(this);
                                    Util.setUsuario(u);
                                    pj.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    SqlDataReader dr = sql.consulta("SELECT * FROM Character WHERE id_character = '" + lector[2].ToString() + "'");
                                    if (dr.Read())
                                    {
                                        int loguear = sql.ejecutar("insert into Logs_User (logDate, id_user) values ('" + System.DateTime.Now + "','" + lector[0].ToString() + "')");
                                        if (loguear > 0)
                                        {
                                            switch (Convert.ToInt32(lector[4]))
                                            {
                                                case 1:
                                                    //Se asigna a la clase usuario los valores
                                                    Usuario u = new Usuario(Convert.ToInt32(lector[0].ToString()), lector[1].ToString(), Convert.ToInt32(lector[2].ToString()), lector[3].ToString(), Convert.ToInt32(lector[4].ToString()));
                                                    //Se le asignan a la clase Characters los valores
                                                    Character c = new Character(Convert.ToInt32(dr[0].ToString()), dr[1].ToString(), Convert.ToInt32(dr[2].ToString()), Convert.ToInt32(dr[3].ToString()),
                                                            Convert.ToInt32(dr[4].ToString()), Convert.ToInt32(dr[5].ToString()), Convert.ToInt32(dr[6].ToString()), Convert.ToInt32(dr[7].ToString()));
                                                    MainMenu mm = new MainMenu();
                                                    Util.setF1(this);
                                                    Util.setUsuario(u);
                                                    Util.setCharacter(c);
                                                    mm.Show();
                                                    this.Hide();
                                                    break;
                                                case 2:
                                                    MessageBox.Show("Usuario Bloqueado", "Mala suerte rufián");
                                                    break;
                                                case 3:
                                                    MessageBox.Show("Usuario Baneado indefinidamente por no cumplir con las reglas", "Pero mira como te denuncio maquinola");
                                                    break;
                                            }
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
                MessageBox.Show(ex.Message, "Error crítico");
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            GM gm = new GM();
            gm.Show();
            Util.setF1(this);
            this.Hide();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            Util.setF1(this);
            this.Hide();
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;

        }
    }
}
