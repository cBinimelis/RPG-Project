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
    public partial class GM_Menu : Form
    {
        public GM_Menu()
        {
            InitializeComponent();
        }

        private void GM_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Util.getF1().Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Usuario MU = new Mantenedores.Mantenedor_Usuario();
            Util.setGmm(this);
            MU.Show();
            this.Hide();
        }

        private void personajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Personajes MP = new Mantenedores.Mantenedor_Personajes();
            Util.setGmm(this);
            MP.Show();
            this.Hide();
        }

        private void ataquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Ataques MA = new Mantenedores.Mantenedor_Ataques();
            Util.setGmm(this);
            MA.Show();
            this.Hide();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Tipos MT = new Mantenedores.Mantenedor_Tipos();
            Util.setGmm(this);
            MT.Show();
            this.Hide();
        }

        private void bloqueosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Bloqueos_User MBU = new Mantenedores.Mantenedor_Bloqueos_User();
            Util.setGmm(this);
            MBU.Show();
            this.Hide();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Estados ME = new Mantenedores.Mantenedor_Estados();
            Util.setGmm(this);
            ME.Show();
            this.Hide();
        }

        private void nPCsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_NPCs MN = new Mantenedores.Mantenedor_NPCs();
            Util.setGmm(this);
            MN.Show();
            this.Hide();
        }

        private void monstruosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Monstruos MM = new Mantenedores.Mantenedor_Monstruos();
            Util.setGmm(this);
            MM.Show();
            this.Hide();
        }

        private void gMsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_GameMasters MGM = new Mantenedores.Mantenedor_GameMasters();
            Util.setGmm(this);
            MGM.Show();
            this.Hide();
        }

        private void bloqueoGameMastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.Mantenedor_Bloqueos_GM MBG = new Mantenedores.Mantenedor_Bloqueos_GM();
            Util.setGmm(this);
            MBG.Show();
            this.Hide();
        }
    }
}
