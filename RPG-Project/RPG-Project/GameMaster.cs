using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class GameMaster
    {
        private int id_gameM;
        private String nameGM;
        private String password;
        private int GM_code;
        private int id_state;

        public GameMaster(int id_gameM, String nameGM, String password, int GM_code, int id_state)
        {
            this.id_gameM = id_gameM;
            this.nameGM = nameGM;
            this.password = password;
            this.GM_code = GM_code;
            this.id_state = id_state;
        }

        public int getId_gameM()
        {
            return id_gameM;
        }

        public void setId_gameM(int id_gameM)
        {
            this.id_gameM = id_gameM;
        }

        public String getNameGM()
        {
            return nameGM;
        }

        public void setNameGM(String nameGM)
        {
            this.nameGM = nameGM;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public int getGM_code()
        {
            return GM_code;
        }

        public void setGM_code(int GM_code)
        {
            this.GM_code = GM_code;
        }

        public int getId_state()
        {
            return id_state;
        }

        public void setId_state(int id_state)
        {
            this.id_state = id_state;
        }
    }
}
