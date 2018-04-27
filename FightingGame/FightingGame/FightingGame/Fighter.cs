using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FightingGame
{
    class Fighter
    {
        public String name;
        public Texture2D[] movementAnimations;
        public int health;
        public Move[] moveset;
        public int speed;
        //hitboxes+hurtboxes
        //armor? maybe later

        public Fighter(String n, Texture2D[] a, int h, Move[] m, int s)
        {
            name = n;
            movementAnimations = a;
            health = h;
            moveset = m;
            speed = s;
        }
    }
}
