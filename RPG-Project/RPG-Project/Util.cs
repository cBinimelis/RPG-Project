using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Util
    {
        private static Form1 f1;
        private static MainMenu mm;
        private static GM_Menu gmm;
        private static Usuario usuario;
        private static Character character;
        private static Ataque1 Ata1;
        private static Ataque2 Ata2;
        private static Ataque3 Ata3;
        private static Ataque4 Ata4;
        private static Monster Mon;
        private static NonPlayableCharacters NPC;
        private static Enemy enemy;
        private static atack atack;

        public static void setF1(Form1 f1)
        {
            Util.f1 = f1;
        }
        public static Form1 getF1()
        {
            return Util.f1;
        }

        public static void setMM(MainMenu mm)
        {
            Util.mm = mm;
        }

        public static MainMenu getMM()
        {
            return Util.mm;
        }

        public static GM_Menu getGmm()
        {
            return gmm;
        }

        public static void setGmm(GM_Menu gmm)
        {
            Util.gmm = gmm;
        }

        public static void setUsuario(Usuario usuario)
        {
            Util.usuario = usuario;
        }
        public static Usuario getUsuario()
        {
            return Util.usuario;
        }

        public static void setCharacter(Character character)
        {
            Util.character = character;
        }
        public static Character getCharacter()
        {
            return Util.character;
        }

        public static void setAtaque1(Ataque1 Ata1)
        {
            Util.Ata1 = Ata1;
        }
        public static Ataque1 getAta1()
        {
            return Util.Ata1;
        }

        public static void setAtaque2(Ataque2 Ata2)
        {
            Util.Ata2 = Ata2;
        }
        public static Ataque2 getAta2()
        {
            return Util.Ata2;
        }

        public static void setAtaque3(Ataque3 Ata3)
        {
            Util.Ata3 = Ata3;
        }
        public static Ataque3 getAta3()
        {
            return Util.Ata3;
        }

        public static void setAtaque4(Ataque4 Ata4)
        {
            Util.Ata4 = Ata4;
        }
        public static Ataque4 getAta4()
        {
            return Util.Ata4;
        }

        public static void setMon(Monster Mon)
        {
            Util.Mon = Mon;
        }
        public static Monster getMon()
        {
            return Util.Mon;
        }

        public static void setNPC(NonPlayableCharacters NPC)
        {
            Util.NPC = NPC;
        }
        public static NonPlayableCharacters getNPC()
        {
            return Util.NPC;
        }

          public static Enemy getEnemy()
        {
            return Util.enemy;
        }

        public static void setEnemy(Enemy enemy)
        {
            Util.enemy = enemy;
        }

        public static atack getAtack()
        {
            return Util.atack;
        }

        public static void setAtack(atack atack)
        {
            Util.atack = atack;
        }
    }
}
