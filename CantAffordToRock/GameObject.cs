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
        protected Game game;
        public Vector2 position = Vector2.Zero;

        public GameObject(Game myGame)
        {
            game = myGame;
        }

        public virtual void LoadContent()
        {
            if (Name != "")
                Texture = game.Content.Load<Texture2D>(Name);
        }

        public virtual void Update(float deltaTime)
        {
        }

        public virtual void Draw(SpriteBatch batch)
        {
            if (Texture == null)
                return;
            Vector2 drawPosition = position;
            drawPosition.X -= Texture.Width / 2;
            drawPosition.Y -= Texture.Height / 2;
            batch.Draw(Texture, drawPosition, Color.White);
        }
    }
}
