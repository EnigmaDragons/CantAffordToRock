using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CantAffordToRock.Engine
{
    public interface IGameView
    {
        void LoadContent();
        void UnloadContent();
        void Update(GameTime deltaTime);
        void Draw(SpriteBatch sprites);
    }
}
