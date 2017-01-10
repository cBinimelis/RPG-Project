using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class NonPlayableCharacters
    {
        private int id;
        private String nombre;
        private int poder;
        private int lvl;

        public NonPlayableCharacters(int id, String nombre, int poder, int lvl)
        {
            this.id = id;
            this.nombre = nombre;
            this.poder = poder;
            this.lvl = lvl;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public int getPoder()
        {
            return poder;
        }

        public void setPoder(int poder)
        {
            this.poder = poder;
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
