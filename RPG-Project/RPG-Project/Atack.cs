using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class atack
    {
        private String Attack_name;
        private int danio;

        public atack(String Attack_name, int danio) {
            this.Attack_name = Attack_name;
            this.danio = danio;
        }
        public String getAttack_name()
        {
            return Attack_name;
        }

        public void setAttack_name(String Attack_name)
        {
            this.Attack_name = Attack_name;
        }

        public int getDanio()
        {
            return danio;
        }

        public void setDanio(int danio)
        {
            this.danio = danio;
        }
    }
}
