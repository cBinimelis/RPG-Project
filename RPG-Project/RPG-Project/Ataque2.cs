using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Ataque2
    {
        private int id_attack;
        private int id_type;
        private String Attack_name;
        private int coste;
        private int danio;

        public Ataque2(int id_attack, int id_type, String Attack_name, int coste, int danio)
        {
            this.id_attack = id_attack;
            this.id_type = id_type;
            this.Attack_name = Attack_name;
            this.coste = coste;
            this.danio = danio;
        }

        public int getId_attack()
        {
            return id_attack;
        }

        public void setId_attack(int id_attack)
        {
            this.id_attack = id_attack;
        }

        public int getId_type()
        {
            return id_type;
        }

        public void setId_type(int id_type)
        {
            this.id_type = id_type;
        }

        public String getAttack_name()
        {
            return Attack_name;
        }

        public void setAttack_name(String Attack_name)
        {
            this.Attack_name = Attack_name;
        }

        public int getCoste()
        {
            return coste;
        }

        public void setCoste(int coste)
        {
            this.coste = coste;
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
