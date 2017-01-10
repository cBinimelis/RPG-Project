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
    public partial class Registro : Form
    {
        SQL sql = new SQL();
        public Registro()
        {
            InitializeComponent();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Trim().Equals("") || txt_pass.Text.Trim().Equals("") || txt_comprobar.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No deben quedar campos vacíos", "Sin prisas");
                }
                else
                {
                    if (!txt_pass.Text.Equals(txt_comprobar.Text))
                    {
                        MessageBox.Show("La contraseña no coincide en ambos campos", "Intenta relajarte...");
                    }
                    else
                    {
                        if (sql.verificar("select * from User1 where nameGM='" + txt_username.Text + "'"))
                        {
                            MessageBox.Show("Ya existe este Usuario", "Sin clones");
                        }
                        else
                        {
                            int r = sql.ejecutar("insert into User1 (user_name, password, id_state) values('" + txt_username.Text + "','" + txt_pass.Text + "','1')");
                            if (r > 0)
                            {
                                MessageBox.Show("Usuario creado correctamente", "¡Bienvenido!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido ingresar el Usuario");
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getF1().Show();
        }
    }
}
