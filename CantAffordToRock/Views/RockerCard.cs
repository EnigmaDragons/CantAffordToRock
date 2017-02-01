using CantAffordToRock.CoreGame;
using CantAffordToRock.MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CantAffordToRock.Views
{
    public class RockerCard
    {
        private readonly Game _game;
        private readonly Rocker _rocker;

        private Texture2D _outline;
        private Texture2D _sampleCharacter;

        public RockerCard(Game game, Rocker rocker)
        {
            _game = game;
            _rocker = rocker;
        }

        public void LoadContent()
        {
            if(_outline == null)
                _outline = new LoadedTexture(_game, "rockercard-outline.png").Get();
            if (_sampleCharacter == null)
                _sampleCharacter = new LoadedTexture(_game, "rockercard-sample.png").Get();
        }

        public void UnloadContent()
        {
            _outline.Dispose();
        }

        public void Draw(SpriteBatch sprites, Vector2 offset)
        {
            LoadContent();
            sprites.Draw(_outline, offset);
            sprites.Draw(_sampleCharacter, offset);
        }
    }
}
