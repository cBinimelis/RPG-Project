using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Usuario
    {
        private int id_user, id_character, id_state;
        private String user_name, pass;

        public Usuario(int id_user, String user_name, int id_character, String pass, int id_state)
        {
            this.id_user = id_user;
            this.user_name = user_name;
            this.id_character = id_character;
            this.pass = pass;
            this.id_state = id_state;
        }

        public int getId_user()
        {
            return id_user;
        }

        public void setId_user(int id_user)
        {
            this.id_user = id_user;
        }

        public int getId_character()
        {
            return id_character;
        }

        public void setId_character(int id_character)
        {
            this.id_character = id_character;
        }

        public int getId_state()
        {
            return id_state;
        }

        public void setId_state(int id_state)
        {
            this.id_state = id_state;
        }

        public String getUser_name()
        {
            return user_name;
        }

        public void setUser_name(String user_name)
        {
            this.user_name = user_name;
        }

        public String getPass()
        {
            return pass;
        }

        public void setPass(String pass)
        {
            this.pass = pass;
        }
    }
}
