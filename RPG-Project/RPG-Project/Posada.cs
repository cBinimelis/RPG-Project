using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Project
{
    public partial class Posada : Form
    {
        int gold = Util.getCharacter().getGold();
        public Posada()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Has entrado al modo trampa, puedes subir un nivel inmediatamente si lo puedes pagar","Será la módica suma de $2500",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Util.getCharacter().setLvl(Util.getCharacter().getLvl() + 1);
                MessageBox.Show("¡Subes un nivel!","Felicidades(?)");
            }
            else
            {
                MessageBox.Show("Nos vemos pronto", "Sé que volverás");
            }
        }

        private void Posada_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getMM().Show();
        }

        private void Posada_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            lbl_gold.Text = Util.getCharacter().getGold().ToString();
            pb_life.Value = Util.getCharacter().getLife();
            pb_stamina.Value = Util.getCharacter().getStamina();
        }

        private void btn_restauraTodo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea realizar esta compra?", "Serían $150",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Util.getCharacter().getGold() < 150)
                {
                    MessageBox.Show("No tienes dinero suficiente");
                }
                else
                {
                    Util.getCharacter().setGold(Util.getCharacter().getGold() - 150);
                    Util.getCharacter().setLife(250);
                    Util.getCharacter().setStamina(100);
                    Actualizar();
                }
            }
        }

        private void btn_descanso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea realizar esta compra?", "Serían $50",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Util.getCharacter().getGold() < 50)
                {
                    MessageBox.Show("No tienes dinero suficiente");
                }
                else
                {
                    Util.getCharacter().setGold(Util.getCharacter().getGold() - 50);
                    Util.getCharacter().setStamina(Util.getCharacter().getStamina()+50);
                    Actualizar();
                }
            }
        }

        private void btn_curar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea realizar esta compra?", "Serían $50",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Util.getCharacter().getGold() < 50)
                {
                    MessageBox.Show("No tienes dinero suficiente");
                }
                else
                {
                    Util.getCharacter().setGold(Util.getCharacter().getGold() - 50);
                    Util.getCharacter().setLife(Util.getCharacter().getLife() + 150);
                    Actualizar();
                }
            }
        }
    }
}
