﻿
namespace Monopoly.View.UI
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Background
    {
        private Sprite sprite;

        public Background(Sprite sprite)
        {
            this.sprite = sprite;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.sprite.Image, this.sprite.Rectangle, Color.White);
        }
    }
}
