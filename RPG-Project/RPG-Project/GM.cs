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
    public partial class GM : Form
    {
        SQL sql = new SQL();
        public GM()
        {
            InitializeComponent();
        }


        private void GM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getF1().Show();
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text.Trim().Equals("") || txt_pass.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No deben quedar campos incompletos", "No se me apure");
                }
                else
                {
                    //Verifica si el usuario ingresado es un usuario comun
                    if (sql.verificar("select * from User1 where user_name = '" + txt_user.Text + "'") == true)
                    {
                        MessageBox.Show("Usuario con acceso limitado, no puedes ingresar", "El que mucho abarca...");
                        Util.getF1().Show();
                        this.Close();
                    }
                    else
                    {
                        //Verifica si el usuario ingresado existe dentro de la base de datos
                        SqlDataReader lector = sql.consulta("select * from gameMaster where nameGM = '" + txt_user.Text + "'");
                        if (lector.Read() == false)
                        {
                            MessageBox.Show("Su usuario no existe, contáctese con su administrador", "Hay una serpiente en mi bota");
                        }
                        else
                        {
                            if (lector[2].Equals(txt_pass.Text) == false)
                            {
                                sql.ejecutar("insert into Block_GM (reason, blockDate, id_gameM) values('Contraseña erronea','" + System.DateTime.Now + "'," + lector[0].ToString() + ")");
                                SqlDataReader dr = sql.consulta("select count(id_block) from Block_GM where id_gameM='" + lector[0].ToString() + "'");
                                if (dr.Read())
                                {
                                    if (Convert.ToInt32(dr[0]) > 2)
                                    {
                                        sql.ejecutar("update gameMaster set id_state = 2 where id_gameM='" + lector[0].ToString() + "'");
                                        MessageBox.Show("Su usuario ha sido bloqueado", "Mejor busca otro empleo...");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Contraseña incorrecta, al tercer error se bloqueará su cuenta", dr[0].ToString() + " veces mal ingresado");
                                    }
                                }
                            }
                            else
                            {
                                int loguear = sql.ejecutar("insert into Logs_GM (logDate, id_gameM) values ('" + System.DateTime.Now + "','" + lector[0].ToString() + "')");
                                if (loguear > 0)
                                {
                                    switch (Convert.ToInt32(lector[4]))
                                    {
                                        case 1:
                                            GM_Menu gmm = new GM_Menu();
                                            gmm.Show();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error crítico");
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
                
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
