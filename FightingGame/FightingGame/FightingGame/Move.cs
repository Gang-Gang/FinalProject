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
    class Move
    {
        Texture2D[] animations;
        String name;
        int damage;

        public Move(Texture2D[] a, String n, int d)
        {
            animations = a;
            name = n;
            damage = d;
        }
    }
}
