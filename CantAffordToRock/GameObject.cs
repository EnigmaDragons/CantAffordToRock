using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CantAffordToRock
{
    public class GameObject
    {
        protected string Name = "";
        protected Texture2D Texture;
        protected Microsoft.Xna.Framework.Game game;
        public Vector2 Position = Vector2.Zero;

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
            drawPosition.X -= Texture.Width / 2;
            drawPosition.Y -= Texture.Height / 2;
            batch.Draw(Texture, drawPosition, Color.White);
        }
    }
}
