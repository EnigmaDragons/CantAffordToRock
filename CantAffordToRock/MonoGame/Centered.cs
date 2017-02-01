using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CantAffordToRock.MonoGame
{
    public class Centered
    {
        private readonly Game _game;
        private readonly Texture2D _texture;

        public Centered(Game game, Texture2D texture)
        {
            _game = game;
            _texture = texture;
        }

        public void Draw(SpriteBatch sprites)
        {
            var screenCenter = new Vector2(_game.GraphicsDevice.Viewport.Bounds.Width / 2,
                _game.GraphicsDevice.Viewport.Bounds.Height / 2);
            var textureCenter = new Vector2(_texture.Width / 2, _texture.Height / 2);
            sprites.Draw(_texture, screenCenter, null, Color.White, 0f, textureCenter, 1f, SpriteEffects.None, 1f);
        }
    }
}
