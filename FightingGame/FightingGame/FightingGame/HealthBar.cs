using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FightingGame
{
    class HealthBar
    {
        private Texture2D life;
        private Vector2 position;
        private Vector2 position2;
        private int fullHealth = 500;
        private int currentHealth;
        private int rateOfChange = 1;
        private Color barColor;

        public HealthBar(ContentManager content)
        {
            position = new Vector2(0, 0);
            position2 = new Vector2(425, 0);
            LoadContent(content);
            //fullHealth = life.Width;
            currentHealth = fullHealth;
            
        }

        private void LoadContent(ContentManager content)
        {
           
            life = content.Load<Texture2D>("healthGauge");
        }
        public void Update()
        {
            
            if (currentHealth > 0)
            {
                currentHealth -= rateOfChange;
            }
            HealthColor();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(life, position, new Rectangle((int)position.X, (int)position.Y, currentHealth, life.Height), barColor);
            spriteBatch.Draw(life, position2, new Rectangle((int)position.X, (int)position.Y, currentHealth, life.Height), barColor);

        }
        public void HealthColor()
        {
            if(currentHealth >= fullHealth * 0.75)
            {
                barColor = Color.Green;
            }
            else if(currentHealth >= fullHealth * 0.25 && currentHealth < fullHealth * .75)
            {
                barColor = Color.Yellow;
            }
            else if (currentHealth <= fullHealth)
            {
                barColor = Color.Red;
            }
        }
    }
}
