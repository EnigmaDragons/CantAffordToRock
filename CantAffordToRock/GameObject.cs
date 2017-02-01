using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CantAffordToRock
{
    public class GameObject
    {
        protected readonly Microsoft.Xna.Framework.Game game;

        protected string Name = "";
        protected Texture2D Texture;
        protected Vector2 Position = Vector2.Zero;
        protected float Scale = 1;

        public GameObject(Microsoft.Xna.Framework.Game myGame)
        {
            game = myGame;
        }

        public virtual void LoadContent()
        {
            if (Name != "")
                Texture = game.Content.Load<Texture2D>(Name);
        }

        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Draw(SpriteBatch batch)
        {
            if (Texture == null)
                return;
            Vector2 drawPosition = Position;
            drawPosition.X -= Texture.Width * Scale / 2;
            drawPosition.Y -= Texture.Height * Scale / 2;
            batch.Draw(Texture, drawPosition, null, Color.White, 0f, drawPosition, Scale, SpriteEffects.None, 0f);
        }
    }
}
