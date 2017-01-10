using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Enemy
    {
        private int id_character;
        private String character_name;
        private int id_type;
        private int life;
        private int stamina;
        private int lvl;

        public Enemy(int id_character, String character_name, int id_type, int life, int stamina, int lvl)
        {
            this.id_character = id_character;
            this.character_name = character_name;
            this.id_type = id_type;
            this.life = life;
            this.stamina = stamina;
            this.lvl = lvl;
        }

        public int getId_character()
        {
            return id_character;
        }

        public void setId_character(int id_character)
        {
            this.id_character = id_character;
        }

        public String getCharacter_name()
        {
            return character_name;
        }

        public void setCharacter_name(String character_name)
        {
            this.character_name = character_name;
        }

        public int getId_type()
        {
            return id_type;
        }

        public void setId_type(int id_type)
        {
            this.id_type = id_type;
        }

        public int getLife()
        {
            return life;
        }

        public void setLife(int life)
        {
            this.life = life;
        }

        public int getStamina()
        {
            return stamina;
        }

        public void setStamina(int stamina)
        {
            this.stamina = stamina;
        }

        public int getLvl()
        {
            return lvl;
        }

        public void setLvl(int lvl)
        {
            this.lvl = lvl;
        }
    }
}

